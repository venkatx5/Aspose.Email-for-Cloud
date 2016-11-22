# Aspose.Email Cloud SDK for Node.js

This repository contains Aspose.Email Cloud SDK for Node.js source code. This SDK allows you to work with Aspose.Email Cloud REST APIs in your Node.js applications quickly and easily. 

##How to use the SDK?
The complete source code is available in this repository folder, you can either directly use it in your project or use Maven. For more details, please visit our [documentation website](http://www.aspose.com/docs/display/emailcloud/Available+SDKs).

## Quick SDK Tutorial
```javascript
var fs = require('fs');
var assert = require('assert');
var StorageApi =require("asposestoragecloud")
var EmailApi = require('asposeemailcloud');

var AppSID = 'XXX'; //sepcify App SID
var AppKey = 'XXX'; //sepcify App Key
var config = {'appSid':AppSID,'apiKey':AppKey};
var data_path = '../data/';

try {
//Instantiate Aspose.Storage API SDK
var storageApi = new StorageApi(config);

//Instantiate Aspose.Email API SDK
var emailApi = new EmailApi(config);

//set input file name
var filename = "email_test2";;
var name = filename + ".eml";
var format = "msg";

//upload file to aspose cloud storage
storageApi.PutCreate(name, null, null, file= data_path + name , function(responseMessage) {
	assert.equal(responseMessage.status, 'OK');
	//invoke Aspose.Email Cloud SDK API to convert message to other formats
	emailApi.GetDocumentWithFormat(name, format, storage, folder, null, function(responseMessage) {
			assert.equal(responseMessage.status, 'OK');		
			//download converted email message from api response
			var outfilename = filename + '.' + format;
			var writeStream = fs.createWriteStream('c:/temp/' + outfilename);
			writeStream.write(responseMessage.body);
			});
	});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
```

##Contact Us
Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://www.aspose.com/community/forums/).
