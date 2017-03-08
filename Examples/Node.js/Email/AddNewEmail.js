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
var name =  "email_test2.eml";

var body = {
'DocumentProperties' : {
	'List' : [

		{
			'Name' : 'Body',
			'Value' : 'This is a body'
		},

		{
			'Name' : 'To',
			'Value' : 'developer@aspose.com'
		},

		{
			'Name' : 'From',
			'Value' : 'sales@aspose.com'
		}
		]
								},
								'Format' : 'eml'
							};

var storage = null;
var folder = null;

try {
	// Upload source file to aspose cloud storage
	storageApi.PutCreate(name, null, null, data_path + name , function(responseMessage) {
		assert.equal(responseMessage.status, 'OK');

		// Invoke Aspose.Email Cloud SDK API to add new email
		emailApi.PutCreateNewEmail(name, storage, folder, body, function(responseMessage) {
				assert.equal(responseMessage.status, 'OK');
				
				// Download email from cloud storage
				storageApi.GetDownload(name, null, null, function(responseMessage) {
					assert.equal(responseMessage.status, 'OK');
					var outfilename = 'appended-' + name;
					var writeStream = fs.createWriteStream(data_path + outfilename);
					writeStream.write(responseMessage.body);
				});
			});
	});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1