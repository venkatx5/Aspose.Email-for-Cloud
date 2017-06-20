var path = require('path');
var fs = require('fs');
var util = require('util');
var crypto = require('crypto');
var http = require('http');
var url = require('url');
var ResponseMessage = require('./response-message');
var Multipart = require('./multipart').Multipart;

// config values for api client
var config = {
  'apiKey' : null,
  'appSid' : null,
  'baseURI' : 'http://api.aspose.cloud/v1.1',
  'debug' : false
};

//config values required for api client
var required_for_api_client = [
  'apiKey',
  'appSid'
];

function ApiClient(aconfig){
	var self = this;
	self._validateConfigOrThrow(aconfig);
	
	for (var key in aconfig) {
		if (aconfig[key]) {
			config[key] = aconfig[key];
		}
	}
	this.config = config;
}


ApiClient.prototype._validateConfigOrThrow = function (config) {
//check config for proper format
if (typeof config !== 'object') {
throw new TypeError('config must be object, got ' + typeof config);
}

var required_keys = required_for_api_client;

required_keys.forEach(function (req_key) {
if (!config[req_key]) {
 var err_msg = util.format('Config must include `%s` when using ApiClient.', req_key);   
 throw new Error(err_msg);
}
})

}

ApiClient.prototype.Sign = function(unsignedURL, privateKey){
	
	if(this.config.debug){console.log("privateKey :: " + privateKey); console.log("unsignedURL :: " + unsignedURL);}
	
	var signature = crypto.createHmac('sha1', privateKey)
		.update(unsignedURL)
		.digest('hex')
		.replace('=', '');
	

	return signature;
};

ApiClient.prototype.InvokeSimpleBody = function(resourceURL, method, postData, headerParams,  callback){
	
	if(this.config.debug){console.log("InvokeSimpleBody");}

	var request_url = url.parse(resourceURL);

	var options = {
		method: method,
		protocol: request_url.protocol,
		hostname: request_url.hostname,
		path: request_url.path,
		headers:headerParams
	};

	if (postData) {
		options.headers['Content-Length'] = postData.length;
	} else {
		options.headers['Content-Length'] = 0;
	}
	
	var response_buffer = null;
	var responseMessage = new ResponseMessage();
	var request = http.request(options);
	
	request.on('response', function(response) {
		
		responseMessage.code = response.statusCode;
		responseMessage.status = response.statusMessage;
		
		response.on('data', function(chunk) {
			if (response_buffer) {
				if (typeof (Buffer.concat) === 'function') {
					response_buffer = Buffer.concat([response_buffer, chunk]);
				} else {
					var holder = new Buffer(response_buffer.length + chunk.length);
					response_buffer.copy(holder);
					chunk.copy(holder, response_buffer.length);
					response_buffer = holder;
				}
			} else {
				response_buffer = chunk;
			}
		});

		response.on('end', function() {
			
			if (typeof callback === 'function') {
				
				if(response.headers['content-type'] !== 'undefined' && String(response.headers['content-type']).indexOf("application/json") > -1 ){					
					responseMessage.body = JSON.parse(response_buffer.toString('utf-8'));
				}else{responseMessage.body = response_buffer;}
				
				callback.call(null, responseMessage);
			}
		});
	});

	if (postData) {
		request.end(postData);
	} else {
		request.end();
	}
	
}

ApiClient.prototype.InvokeMultiPartBody = function(resourceURL, method, headerParams,  files, callback){
	
	if(this.config.debug){console.log("InvokeMultiPartBody")};

	var request_url = url.parse(resourceURL);

	var options = {
		method: method,
		protocol: request_url.protocol,
		hostname: request_url.hostname,
		path: request_url.path,
		headers:headerParams
	};

	
	var response_buffer = null;
	var responseMessage = new ResponseMessage();
	
	var request = http.request(options);
	
	var multipart = new Multipart(request);
	var postData = multipart.build(files, false);
	multipart.setHeaders(false);
	
	request.on('response', function(response) {
		
		console.log(response.statusCode);
		responseMessage.code = response.statusCode;
		responseMessage.status = response.statusMessage;
		
		response.on('data', function(chunk) {
			if (response_buffer) {
				if (typeof (Buffer.concat) === 'function') {
					response_buffer = Buffer.concat([response_buffer, chunk]);
				} else {
					var holder = new Buffer(response_buffer.length + chunk.length);
					response_buffer.copy(holder);
					chunk.copy(holder, response_buffer.length);
					response_buffer = holder;
				}
			} else {
				response_buffer = chunk;
			}
		});

		response.on('end', function() {
			
			if (typeof callback === 'function') {
				console.log(response.headers['content-type']);
				console.log(JSON.stringify(response.headers['content-type']));
				
				if(response.headers['content-type'] !== 'undefined' && String(response.headers['content-type']).indexOf("application/json") > -1 ){					
					responseMessage.body = JSON.parse(response_buffer.toString('utf-8'));
				}else{responseMessage.body = response_buffer;}
				
				callback.call(null, responseMessage);
			}
		});
	});

	request.on('error', function(error) {
		console.log("this is error " +  error);
		callback.call(null, responseMessage);
	});
	
	
	if (postData) {
        if (Array.isArray(postData)) {
        	postData.forEach(function (part) {            
            request.write(part);
          })

        } else {
          request.write(postData);
        }
        request.end();
	} else {
		request.end();
	}
	
}

ApiClient.prototype.InvokeAPI = function(resourceURL, method, queryParams, postData, headerParams,  files, callback){
	
	resourceURL = resourceURL.replace("{appSid}", this.config.appSid);
	
	var regex = new RegExp('\\{\\w*\\}', 'g');
	resourceURL = resourceURL.replace(regex, "");
	
	if(this.config.debug){console.log("resourceURL :: " + resourceURL);}
	
	resourceURL = this.config.baseURI +  resourceURL;
	
	var signature =  this.Sign(resourceURL, this.config.apiKey);
	
	if(this.config.debug){console.log("signature :: " + signature);}
	
	resourceURL = resourceURL +  "&signature=" + signature;
	
	if(this.config.debug){console.log("Final resourceURL :: " + method + " " + resourceURL);}

	if(postData === null && Array.isArray(files) && files.length > 1 ){
		return this.InvokeMultiPartBody(resourceURL, method, headerParams, files, callback)
	}else{
		return this.InvokeSimpleBody(resourceURL, method, postData, headerParams, callback)
	}
}


module.exports = ApiClient;
