var path = require('path');
var fs = require('fs');
var apiClient = require('./api-client');


function EmailApi(config) {
	var self = this;
	
	apiClient = new apiClient(config);
	this.config = apiClient.config;
}


/**
* AppendMessage
* Append message from a storage
*
* @param  (String) storage  -   (optional) 
* @param  (String) accountName1  -   (optional) 
* @param  (String) accountName2  -   (optional) 
* @param  (String) folder  -   (optional) 
* @param  (String) mailPath  -   (optional) 
* @param  (Boolean) markAsSent  -   (optional) 
* @returns SaaSposeResponse (Map)
*/
EmailApi.prototype.AppendMessage = function(storage, accountName1, accountName2, folder, mailPath, markAsSent, callback) {

    var self = this;
	      	
		
	var resourcePath = '/email/client/Append/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;folder={folder}&amp;mailPath={mailPath}&amp;markAsSent={markAsSent}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName1 !== 'undefined' &&  accountName1 !== null && accountName1!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName1" + "}" , accountName1);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName1.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName2 !== 'undefined' &&  accountName2 !== null && accountName2!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName2" + "}" , accountName2);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName2.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof folder !== 'undefined' &&  folder !== null && folder!== ''){            
			resourcePath = resourcePath.replace("{" + "folder" + "}" , folder);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]folder.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof mailPath !== 'undefined' &&  mailPath !== null && mailPath!== ''){            
			resourcePath = resourcePath.replace("{" + "mailPath" + "}" , mailPath);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]mailPath.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof markAsSent !== 'undefined' &&  markAsSent !== null && markAsSent!== ''){            
			resourcePath = resourcePath.replace("{" + "markAsSent" + "}" , markAsSent);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]markAsSent.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'PUT'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/json'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* AppendMimeMessage
* Append mime message
*
* @param  (String) storage  -   (optional) 
* @param  (String) accountName1  -   (optional) 
* @param  (String) accountName2  -   (optional) 
* @param  (String) folder  -   (optional) 
* @param  (Boolean) markAsSent  -   (optional) 
* @param  () body  -   (required) 
* @returns SaaSposeResponse (Map)
*/
EmailApi.prototype.AppendMimeMessage = function(storage, accountName1, accountName2, folder, markAsSent, body, callback) {

    var self = this;
	     	
		
	var resourcePath = '/email/client/AppendMime/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;folder={folder}&amp;markAsSent={markAsSent}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName1 !== 'undefined' &&  accountName1 !== null && accountName1!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName1" + "}" , accountName1);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName1.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName2 !== 'undefined' &&  accountName2 !== null && accountName2!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName2" + "}" , accountName2);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName2.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof folder !== 'undefined' &&  folder !== null && folder!== ''){            
			resourcePath = resourcePath.replace("{" + "folder" + "}" , folder);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]folder.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof markAsSent !== 'undefined' &&  markAsSent !== null && markAsSent!== ''){            
			resourcePath = resourcePath.replace("{" + "markAsSent" + "}" , markAsSent);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]markAsSent.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'PUT'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = JSON.stringify(body);
    
	
	headerParams['Accept'] = 'application/xml,application/octet-stream'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* CreateFolder
* Creates the new folder
*
* @param  (String) storage  -   (optional) 
* @param  (String) accountName1  -   (optional) 
* @param  (String) accountName2  -   (optional) 
* @param  (String) parentFolder  -   (optional) 
* @param  (String) name  -   (optional) 
* @returns SaaSposeResponse (Map)
*/
EmailApi.prototype.CreateFolder = function(storage, accountName1, accountName2, parentFolder, name, callback) {

    var self = this;
	     	
		
	var resourcePath = '/email/client/CreateFolder/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;parentFolder={parentFolder}&amp;name={name}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName1 !== 'undefined' &&  accountName1 !== null && accountName1!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName1" + "}" , accountName1);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName1.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName2 !== 'undefined' &&  accountName2 !== null && accountName2!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName2" + "}" , accountName2);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName2.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof parentFolder !== 'undefined' &&  parentFolder !== null && parentFolder!== ''){            
			resourcePath = resourcePath.replace("{" + "parentFolder" + "}" , parentFolder);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]parentFolder.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof name !== 'undefined' &&  name !== null && name!== ''){            
			resourcePath = resourcePath.replace("{" + "name" + "}" , name);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]name.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'PUT'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/xml,application/octet-stream'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* DeleteFolder
* Deletes the folder
*
* @param  (String) storage  -   (optional) 
* @param  (String) accountName1  -   (optional) 
* @param  (String) accountName2  -   (optional) 
* @param  (String) folder  -   (optional) 
* @param  (Boolean) deletePermanently  -   (optional) 
* @returns SaaSposeResponse (Map)
*/
EmailApi.prototype.DeleteFolder = function(storage, accountName1, accountName2, folder, deletePermanently, callback) {

    var self = this;
	     	
		
	var resourcePath = '/email/client/DeleteFolder/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;folder={folder}&amp;deletePermanently={deletePermanently}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName1 !== 'undefined' &&  accountName1 !== null && accountName1!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName1" + "}" , accountName1);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName1.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName2 !== 'undefined' &&  accountName2 !== null && accountName2!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName2" + "}" , accountName2);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName2.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof folder !== 'undefined' &&  folder !== null && folder!== ''){            
			resourcePath = resourcePath.replace("{" + "folder" + "}" , folder);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]folder.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof deletePermanently !== 'undefined' &&  deletePermanently !== null && deletePermanently!== ''){            
			resourcePath = resourcePath.replace("{" + "deletePermanently" + "}" , deletePermanently);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]deletePermanently.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'DELETE'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/xml,application/octet-stream'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* DeleteMessage
* Deletes the mail message
*
* @param  (String) storage  -   (optional) 
* @param  (String) accountName1  -   (optional) 
* @param  (String) accountName2  -   (optional) 
* @param  (String) messageId  -   (optional) 
* @param  (Boolean) deletePermanently  -   (optional) 
* @returns SaaSposeResponse (Map)
*/
EmailApi.prototype.DeleteMessage = function(storage, accountName1, accountName2, messageId, deletePermanently, callback) {

    var self = this;
	     	
		
	var resourcePath = '/email/client/DeleteMessage/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;messageId={messageId}&amp;deletePermanently={deletePermanently}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName1 !== 'undefined' &&  accountName1 !== null && accountName1!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName1" + "}" , accountName1);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName1.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName2 !== 'undefined' &&  accountName2 !== null && accountName2!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName2" + "}" , accountName2);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName2.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof messageId !== 'undefined' &&  messageId !== null && messageId!== ''){            
			resourcePath = resourcePath.replace("{" + "messageId" + "}" , messageId);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]messageId.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof deletePermanently !== 'undefined' &&  deletePermanently !== null && deletePermanently!== ''){            
			resourcePath = resourcePath.replace("{" + "deletePermanently" + "}" , deletePermanently);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]deletePermanently.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'DELETE'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/xml,application/octet-stream'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* FetchMessage
* Fetches the message from server
*
* @param  (String) storage  -   (optional) 
* @param  (String) accountName1  -   (optional) 
* @param  (String) accountName2  -   (optional) 
* @param  (String) messageId  -   (optional) 
* @returns MimeResponse (Map)
*/
EmailApi.prototype.FetchMessage = function(storage, accountName1, accountName2, messageId, callback) {

    var self = this;
	    	
		
	var resourcePath = '/email/client/Fetch/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;messageId={messageId}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName1 !== 'undefined' &&  accountName1 !== null && accountName1!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName1" + "}" , accountName1);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName1.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName2 !== 'undefined' &&  accountName2 !== null && accountName2!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName2" + "}" , accountName2);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName2.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof messageId !== 'undefined' &&  messageId !== null && messageId!== ''){            
			resourcePath = resourcePath.replace("{" + "messageId" + "}" , messageId);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]messageId.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'GET'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/xml,application/octet-stream'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* ListFolders
* Gets collection of child folders from parent
*
* @param  (String) storage  -   (optional) 
* @param  (String) accountName1  -   (optional) 
* @param  (String) accountName2  -   (optional) 
* @param  (String) parentFolder  -   (optional) 
* @returns ListFoldersResponse (Map)
*/
EmailApi.prototype.ListFolders = function(storage, accountName1, accountName2, parentFolder, callback) {

    var self = this;
	    	
		
	var resourcePath = '/email/client/ListFolders/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;parentFolder={parentFolder}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName1 !== 'undefined' &&  accountName1 !== null && accountName1!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName1" + "}" , accountName1);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName1.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName2 !== 'undefined' &&  accountName2 !== null && accountName2!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName2" + "}" , accountName2);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName2.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof parentFolder !== 'undefined' &&  parentFolder !== null && parentFolder!== ''){            
			resourcePath = resourcePath.replace("{" + "parentFolder" + "}" , parentFolder);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]parentFolder.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'GET'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/xml,application/octet-stream'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* ListMessages
* List the messages in the specified folder.
*
* @param  (String) storage  -   (optional) 
* @param  (String) accountName1  -   (optional) 
* @param  (String) accountName2  -   (optional) 
* @param  (String) folder  -   (optional) 
* @param  (Boolean) recursive  -   (optional) 
* @param  (String) queryString  -   (optional) 
* @returns ListResponse (Map)
*/
EmailApi.prototype.ListMessages = function(storage, accountName1, accountName2, folder, recursive, queryString, callback) {

    var self = this;
	      	
		
	var resourcePath = '/email/client/ListMessages/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;folder={folder}&amp;recursive={recursive}&amp;queryString={queryString}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName1 !== 'undefined' &&  accountName1 !== null && accountName1!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName1" + "}" , accountName1);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName1.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName2 !== 'undefined' &&  accountName2 !== null && accountName2!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName2" + "}" , accountName2);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName2.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof folder !== 'undefined' &&  folder !== null && folder!== ''){            
			resourcePath = resourcePath.replace("{" + "folder" + "}" , folder);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]folder.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof recursive !== 'undefined' &&  recursive !== null && recursive!== ''){            
			resourcePath = resourcePath.replace("{" + "recursive" + "}" , recursive);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]recursive.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof queryString !== 'undefined' &&  queryString !== null && queryString!== ''){            
			resourcePath = resourcePath.replace("{" + "queryString" + "}" , queryString);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]queryString.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'GET'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/xml,application/octet-stream'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* SaveMailAccount
* Get mail common info.
*
* @param  (String) storage  -   (required) 
* @param  (String) accountName  -   (required) 
* @param  (String) host  -   (required) 
* @param  (String) port  -   (required) 
* @param  (String) login  -   (required) 
* @param  (String) password  -   (required) 
* @param  (String) securityOptions  -   (required) 
* @param  (String) protocolType  -   (required) 
* @param  (String) description  -   (required) 
* @returns SaaSposeResponse (Map)
*/
EmailApi.prototype.SaveMailAccount = function(storage, accountName, host, port, login, password, securityOptions, protocolType, description, callback) {

    var self = this;
	
	if( typeof storage === 'undefined' || storage === null && storage === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof accountName === 'undefined' || accountName === null && accountName === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof host === 'undefined' || host === null && host === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof port === 'undefined' || port === null && port === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof login === 'undefined' || login === null && login === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof password === 'undefined' || password === null && password === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof securityOptions === 'undefined' || securityOptions === null && securityOptions === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof protocolType === 'undefined' || protocolType === null && protocolType === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof description === 'undefined' || description === null && description === ''){
		throw new Error('missing required parameters.');
    } 	
		
	var resourcePath = '/email/client/SaveMailAccount/?appSid={appSid}&amp;storage={storage}&amp;accountName={accountName}&amp;host={host}&amp;port={port}&amp;login={login}&amp;password={password}&amp;securityOptions={securityOptions}&amp;protocolType={protocolType}&amp;description={description}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName !== 'undefined' &&  accountName !== null && accountName!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName" + "}" , accountName);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof host !== 'undefined' &&  host !== null && host!== ''){            
			resourcePath = resourcePath.replace("{" + "host" + "}" , host);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]host.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof port !== 'undefined' &&  port !== null && port!== ''){            
			resourcePath = resourcePath.replace("{" + "port" + "}" , port);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]port.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof login !== 'undefined' &&  login !== null && login!== ''){            
			resourcePath = resourcePath.replace("{" + "login" + "}" , login);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]login.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof password !== 'undefined' &&  password !== null && password!== ''){            
			resourcePath = resourcePath.replace("{" + "password" + "}" , password);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]password.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof securityOptions !== 'undefined' &&  securityOptions !== null && securityOptions!== ''){            
			resourcePath = resourcePath.replace("{" + "securityOptions" + "}" , securityOptions);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]securityOptions.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof protocolType !== 'undefined' &&  protocolType !== null && protocolType!== ''){            
			resourcePath = resourcePath.replace("{" + "protocolType" + "}" , protocolType);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]protocolType.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof description !== 'undefined' &&  description !== null && description!== ''){            
			resourcePath = resourcePath.replace("{" + "description" + "}" , description);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]description.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'POST'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/xml,application/octet-stream'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* SaveMailOAuthAccount
* Get mail common info.
*
* @param  (String) storage  -   (required) 
* @param  (String) accountName  -   (required) 
* @param  (String) host  -   (required) 
* @param  (String) port  -   (required) 
* @param  (String) login  -   (required) 
* @param  (String) clientId  -   (required) 
* @param  (String) clientSecret  -   (required) 
* @param  (String) refreshToken  -   (required) 
* @param  (String) securityOptions  -   (required) 
* @param  (String) protocolType  -   (required) 
* @param  (String) description  -   (required) 
* @returns SaaSposeResponse (Map)
*/
EmailApi.prototype.SaveMailOAuthAccount = function(storage, accountName, host, port, login, clientId, clientSecret, refreshToken, securityOptions, protocolType, description, callback) {

    var self = this;
	
	if( typeof storage === 'undefined' || storage === null && storage === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof accountName === 'undefined' || accountName === null && accountName === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof host === 'undefined' || host === null && host === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof port === 'undefined' || port === null && port === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof login === 'undefined' || login === null && login === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof clientId === 'undefined' || clientId === null && clientId === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof clientSecret === 'undefined' || clientSecret === null && clientSecret === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof refreshToken === 'undefined' || refreshToken === null && refreshToken === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof securityOptions === 'undefined' || securityOptions === null && securityOptions === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof protocolType === 'undefined' || protocolType === null && protocolType === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof description === 'undefined' || description === null && description === ''){
		throw new Error('missing required parameters.');
    } 	
		
	var resourcePath = '/email/client/SaveMailOAuthAccount/?appSid={appSid}&amp;storage={storage}&amp;accountName={accountName}&amp;host={host}&amp;port={port}&amp;login={login}&amp;clientId={clientId}&amp;clientSecret={clientSecret}&amp;refreshToken={refreshToken}&amp;securityOptions={securityOptions}&amp;protocolType={protocolType}&amp;description={description}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName !== 'undefined' &&  accountName !== null && accountName!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName" + "}" , accountName);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof host !== 'undefined' &&  host !== null && host!== ''){            
			resourcePath = resourcePath.replace("{" + "host" + "}" , host);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]host.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof port !== 'undefined' &&  port !== null && port!== ''){            
			resourcePath = resourcePath.replace("{" + "port" + "}" , port);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]port.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof login !== 'undefined' &&  login !== null && login!== ''){            
			resourcePath = resourcePath.replace("{" + "login" + "}" , login);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]login.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof clientId !== 'undefined' &&  clientId !== null && clientId!== ''){            
			resourcePath = resourcePath.replace("{" + "clientId" + "}" , clientId);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]clientId.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof clientSecret !== 'undefined' &&  clientSecret !== null && clientSecret!== ''){            
			resourcePath = resourcePath.replace("{" + "clientSecret" + "}" , clientSecret);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]clientSecret.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof refreshToken !== 'undefined' &&  refreshToken !== null && refreshToken!== ''){            
			resourcePath = resourcePath.replace("{" + "refreshToken" + "}" , refreshToken);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]refreshToken.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof securityOptions !== 'undefined' &&  securityOptions !== null && securityOptions!== ''){            
			resourcePath = resourcePath.replace("{" + "securityOptions" + "}" , securityOptions);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]securityOptions.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof protocolType !== 'undefined' &&  protocolType !== null && protocolType!== ''){            
			resourcePath = resourcePath.replace("{" + "protocolType" + "}" , protocolType);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]protocolType.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof description !== 'undefined' &&  description !== null && description!== ''){            
			resourcePath = resourcePath.replace("{" + "description" + "}" , description);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]description.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'POST'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/xml,application/octet-stream'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* Send
* Send mail message from a storage
*
* @param  (String) storage  -   (optional) 
* @param  (String) accountName1  -   (optional) 
* @param  (String) accountName2  -   (optional) 
* @param  (String) mailPath  -   (optional) 
* @returns SaaSposeResponse (Map)
*/
EmailApi.prototype.Send = function(storage, accountName1, accountName2, mailPath, callback) {

    var self = this;
	    	
		
	var resourcePath = '/email/client/Send/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;mailPath={mailPath}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName1 !== 'undefined' &&  accountName1 !== null && accountName1!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName1" + "}" , accountName1);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName1.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName2 !== 'undefined' &&  accountName2 !== null && accountName2!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName2" + "}" , accountName2);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName2.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof mailPath !== 'undefined' &&  mailPath !== null && mailPath!== ''){            
			resourcePath = resourcePath.replace("{" + "mailPath" + "}" , mailPath);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]mailPath.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'POST'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/xml,application/octet-stream'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* SendMime
* Send mail message
*
* @param  (String) storage  -   (optional) 
* @param  (String) accountName1  -   (optional) 
* @param  (String) accountName2  -   (optional) 
* @param  () body  -   (required) 
* @returns SaaSposeResponse (Map)
*/
EmailApi.prototype.SendMime = function(storage, accountName1, accountName2, body, callback) {

    var self = this;
	   	
		
	var resourcePath = '/email/client/SendMime/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName1 !== 'undefined' &&  accountName1 !== null && accountName1!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName1" + "}" , accountName1);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName1.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName2 !== 'undefined' &&  accountName2 !== null && accountName2!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName2" + "}" , accountName2);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName2.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'POST'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = JSON.stringify(body);
    
	
	headerParams['Accept'] = 'application/xml,application/octet-stream'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* SetReadFlag
* Marks the specifeid message as read.
*
* @param  (String) storage  -   (optional) 
* @param  (String) accountName1  -   (optional) 
* @param  (String) accountName2  -   (optional) 
* @param  (String) messageId  -   (optional) 
* @param  (Boolean) isRead  -   (optional) 
* @returns SaaSposeResponse (Map)
*/
EmailApi.prototype.SetReadFlag = function(storage, accountName1, accountName2, messageId, isRead, callback) {

    var self = this;
	     	
		
	var resourcePath = '/email/client/SetReadFlag/?appSid={appSid}&amp;storage={storage}&amp;accountName1={accountName1}&amp;accountName2={accountName2}&amp;messageId={messageId}&amp;isRead={isRead}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName1 !== 'undefined' &&  accountName1 !== null && accountName1!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName1" + "}" , accountName1);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName1.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof accountName2 !== 'undefined' &&  accountName2 !== null && accountName2!== ''){            
			resourcePath = resourcePath.replace("{" + "accountName2" + "}" , accountName2);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]accountName2.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof messageId !== 'undefined' &&  messageId !== null && messageId!== ''){            
			resourcePath = resourcePath.replace("{" + "messageId" + "}" , messageId);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]messageId.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof isRead !== 'undefined' &&  isRead !== null && isRead!== ''){            
			resourcePath = resourcePath.replace("{" + "isRead" + "}" , isRead);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]isRead.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'POST'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/xml,application/octet-stream'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* GetDocument
* Get mail common info.
*
* @param  (String) name  -   (required) 
* @param  (String) storage  -   (optional) 
* @param  (String) folder  -   (optional) 
* @returns ResponseMessage (Map)
*/
EmailApi.prototype.GetDocument = function(name, storage, folder, callback) {

    var self = this;
	
	if( typeof name === 'undefined' || name === null && name === ''){
		throw new Error('missing required parameters.');
    }   	
		
	var resourcePath = '/email/{name}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof name !== 'undefined' &&  name !== null && name!== ''){            
			resourcePath = resourcePath.replace("{" + "name" + "}" , name);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]name.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof folder !== 'undefined' &&  folder !== null && folder!== ''){            
			resourcePath = resourcePath.replace("{" + "folder" + "}" , folder);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]folder.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'GET'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/json'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* PutCreateNewEmail
* Add new email.
*
* @param  (String) name  -   (required) 
* @param  (String) storage  -   (optional) 
* @param  (String) folder  -   (optional) 
* @param  (EmailDocument) body  -   (required) 
* @returns EmailDocumentResponse (Map)
*/
EmailApi.prototype.PutCreateNewEmail = function(name, storage, folder, body, callback) {

    var self = this;
	
	if( typeof name === 'undefined' || name === null && name === ''){
		throw new Error('missing required parameters.');
    }   	
		
	var resourcePath = '/email/{name}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof name !== 'undefined' &&  name !== null && name!== ''){            
			resourcePath = resourcePath.replace("{" + "name" + "}" , name);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]name.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof folder !== 'undefined' &&  folder !== null && folder!== ''){            
			resourcePath = resourcePath.replace("{" + "folder" + "}" , folder);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]folder.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'PUT'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = JSON.stringify(body);
    
	
	headerParams['Accept'] = 'application/xml,application/json'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* GetDocumentWithFormat
* Convert mail message to target format.
*
* @param  (String) name  -   (required) 
* @param  (String) format  -   (required) 
* @param  (String) storage  -   (optional) 
* @param  (String) folder  -   (optional) 
* @param  (String) outPath  -   (optional) 
* @returns ResponseMessage (Map)
*/
EmailApi.prototype.GetDocumentWithFormat = function(name, format, storage, folder, outPath, callback) {

    var self = this;
	
	if( typeof name === 'undefined' || name === null && name === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof format === 'undefined' || format === null && format === ''){
		throw new Error('missing required parameters.');
    }    	
		
	var resourcePath = '/email/{name}/?appSid={appSid}&amp;toFormat={toFormat}&amp;storage={storage}&amp;folder={folder}&amp;outPath={outPath}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof name !== 'undefined' &&  name !== null && name!== ''){            
			resourcePath = resourcePath.replace("{" + "name" + "}" , name);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]name.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof format !== 'undefined' &&  format !== null && format!== ''){            
			resourcePath = resourcePath.replace("{" + "format" + "}" , format);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]format.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof folder !== 'undefined' &&  folder !== null && folder!== ''){            
			resourcePath = resourcePath.replace("{" + "folder" + "}" , folder);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]folder.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof outPath !== 'undefined' &&  outPath !== null && outPath!== ''){            
			resourcePath = resourcePath.replace("{" + "outPath" + "}" , outPath);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]outPath.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'GET'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/xml,application/octet-stream'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* GetEmailAttachment
* Get email attachment by name.
*
* @param  (String) name  -   (required) 
* @param  (String) attachName  -   (required) 
* @param  (String) storage  -   (optional) 
* @param  (String) folder  -   (optional) 
* @returns ResponseMessage (Map)
*/
EmailApi.prototype.GetEmailAttachment = function(name, attachName, storage, folder, callback) {

    var self = this;
	
	if( typeof name === 'undefined' || name === null && name === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof attachName === 'undefined' || attachName === null && attachName === ''){
		throw new Error('missing required parameters.');
    }   	
		
	var resourcePath = '/email/{name}/attachments/{attachName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof name !== 'undefined' &&  name !== null && name!== ''){            
			resourcePath = resourcePath.replace("{" + "name" + "}" , name);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]name.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof attachName !== 'undefined' &&  attachName !== null && attachName!== ''){            
			resourcePath = resourcePath.replace("{" + "attachName" + "}" , attachName);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]attachName.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof folder !== 'undefined' &&  folder !== null && folder!== ''){            
			resourcePath = resourcePath.replace("{" + "folder" + "}" , folder);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]folder.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'GET'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/xml,application/octet-stream'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* PostAddEmailAttachment
* Add email attachment.
*
* @param  (String) name  -   (required) 
* @param  (String) attachName  -   (required) 
* @param  (String) storage  -   (optional) 
* @param  (String) folder  -   (optional) 
* @returns EmailDocumentResponse (Map)
*/
EmailApi.prototype.PostAddEmailAttachment = function(name, attachName, storage, folder, callback) {

    var self = this;
	
	if( typeof name === 'undefined' || name === null && name === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof attachName === 'undefined' || attachName === null && attachName === ''){
		throw new Error('missing required parameters.');
    }   	
		
	var resourcePath = '/email/{name}/attachments/{attachName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof name !== 'undefined' &&  name !== null && name!== ''){            
			resourcePath = resourcePath.replace("{" + "name" + "}" , name);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]name.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof attachName !== 'undefined' &&  attachName !== null && attachName!== ''){            
			resourcePath = resourcePath.replace("{" + "attachName" + "}" , attachName);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]attachName.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof folder !== 'undefined' &&  folder !== null && folder!== ''){            
			resourcePath = resourcePath.replace("{" + "folder" + "}" , folder);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]folder.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'POST'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/xml,application/json'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* GetEmailProperty
* Read document property by name.
*
* @param  (String) propertyName  -   (required) 
* @param  (String) name  -   (required) 
* @param  (String) storage  -   (optional) 
* @param  (String) folder  -   (optional) 
* @returns ResponseMessage (Map)
*/
EmailApi.prototype.GetEmailProperty = function(propertyName, name, storage, folder, callback) {

    var self = this;
	
	if( typeof propertyName === 'undefined' || propertyName === null && propertyName === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof name === 'undefined' || name === null && name === ''){
		throw new Error('missing required parameters.');
    }   	
		
	var resourcePath = '/email/{name}/properties/{propertyName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof propertyName !== 'undefined' &&  propertyName !== null && propertyName!== ''){            
			resourcePath = resourcePath.replace("{" + "propertyName" + "}" , propertyName);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]propertyName.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof name !== 'undefined' &&  name !== null && name!== ''){            
			resourcePath = resourcePath.replace("{" + "name" + "}" , name);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]name.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof folder !== 'undefined' &&  folder !== null && folder!== ''){            
			resourcePath = resourcePath.replace("{" + "folder" + "}" , folder);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]folder.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'GET'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = null;
    
	
	headerParams['Accept'] = 'application/json'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    
/**
* PutSetEmailProperty
* Set document property.
*
* @param  (String) name  -   (required) 
* @param  (String) propertyName  -   (required) 
* @param  (String) storage  -   (optional) 
* @param  (String) folder  -   (optional) 
* @param  (EmailProperty) body  -   (required) 
* @returns EmailPropertyResponse (Map)
*/
EmailApi.prototype.PutSetEmailProperty = function(name, propertyName, storage, folder, body, callback) {

    var self = this;
	
	if( typeof name === 'undefined' || name === null && name === ''){
		throw new Error('missing required parameters.');
    } 
	if( typeof propertyName === 'undefined' || propertyName === null && propertyName === ''){
		throw new Error('missing required parameters.');
    }   	
		
	var resourcePath = '/email/{name}/properties/{propertyName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}';
	
	resourcePath = resourcePath.replace(new RegExp('\\*', 'g'), "");
	resourcePath = resourcePath.replace(new RegExp('&amp;', 'g'), '&');
	resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}");
	
	
	if(typeof name !== 'undefined' &&  name !== null && name!== ''){            
			resourcePath = resourcePath.replace("{" + "name" + "}" , name);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]name.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof propertyName !== 'undefined' &&  propertyName !== null && propertyName!== ''){            
			resourcePath = resourcePath.replace("{" + "propertyName" + "}" , propertyName);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]propertyName.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof storage !== 'undefined' &&  storage !== null && storage!== ''){            
			resourcePath = resourcePath.replace("{" + "storage" + "}" , storage);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]storage.*?(?=&|\\?|$)', 'g'), "");
		}
	
	if(typeof folder !== 'undefined' &&  folder !== null && folder!== ''){            
			resourcePath = resourcePath.replace("{" + "folder" + "}" , folder);
	}else{
		resourcePath = resourcePath.replace(new RegExp('[&?]folder.*?(?=&|\\?|$)', 'g'), "");
		}
	
	
	if(this.config.debug){console.log('resourcePath :: ' + resourcePath);}
	
    method = 'PUT'
    queryParams = {}
    headerParams = {}
    formParams = {}
    files = {}
	postData = JSON.stringify(body);
    
	
	headerParams['Accept'] = 'application/xml,application/json'
    headerParams['Content-Type'] = 'application/json'

	return apiClient.InvokeAPI(resourcePath, method, queryParams, postData, headerParams, files, callback);
  }
    

module.exports = EmailApi


