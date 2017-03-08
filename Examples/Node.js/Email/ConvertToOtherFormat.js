// ExStart:1
var fs = require('fs');
var assert = require('assert');
var StorageApi = require('asposestoragecloud');
var EmailApi = require('asposeemailcloud');
var configProps = require('../Config/config.json');
var data_path = '../../../Data/';

var AppSID = configProps.app_sid;
var AppKey = configProps.api_key;
var config = {'appSid':AppSID,'apiKey':AppKey , 'debug' : true};

// Instantiate Aspose Storage API SDK
var storageApi = new StorageApi(config);
// Instantiate Aspose.Email API SDK
var emailApi = new EmailApi(config);

// Set input file name
var fileName =  "email_test2";
var name =  fileName + ".eml";
var format = "msg";

var storage = null;
var folder = null;

try {
	// Upload source file to aspose cloud storage
	storageApi.PutCreate(name, null, null, data_path + name , function(responseMessage) {
		assert.equal(responseMessage.status, 'OK');

		// Invoke Aspose.Email Cloud SDK API to convert message to other formats
		emailApi.GetDocumentWithFormat(name, format, storage, folder, null, function(responseMessage) {
				assert.equal(responseMessage.status, 'OK');
				
				// Download converted email message from api response
				var outfilename = fileName + "." + format;
				var writeStream = fs.createWriteStream(data_path + outfilename);
				writeStream.write(responseMessage.body);

			});
	});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1