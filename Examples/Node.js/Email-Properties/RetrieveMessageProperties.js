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
var name =  "email_test.eml";
var storage = null;
var folder = null;

try {
	// Upload source file to aspose cloud storage
	storageApi.PutCreate(name, null, null, data_path + name , function(responseMessage) {
		assert.equal(responseMessage.status, 'OK');

		// Invoke Aspose.Email Cloud SDK API to get email document
		emailApi.GetDocument(name, storage, folder, function(responseMessage) {
				assert.equal(responseMessage.status, 'OK');
				responseMessage.body.DocumentProperties.List.forEach(function(emailProperty) {
					console.log("Property Name :: " + emailProperty.Name);
					console.log("Property Value :: " + emailProperty.Value);

					});
			});

	});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1