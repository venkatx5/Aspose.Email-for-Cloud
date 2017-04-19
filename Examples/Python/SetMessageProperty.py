import asposeemailcloud
from asposeemailcloud.EmailApi import EmailApi
from asposeemailcloud.EmailApi import ApiException
from asposeemailcloud.models import EmailProperty

import asposestoragecloud
from asposestoragecloud.StorageApi import StorageApi
from asposestoragecloud.StorageApi import ResponseMessage

apiKey = "XXXXX" #sepcify App Key
appSid = "XXXXX" #sepcify App SID
apiServer = "http://api.aspose.com/v1.1"
data_folder = "../../data/"

#Instantiate Aspose Storage API SDK
storage_apiClient = asposestoragecloud.ApiClient.ApiClient(apiKey, appSid, True)
storageApi = StorageApi(storage_apiClient)
#Instantiate Aspose Email API SDK
api_client = asposeemailcloud.ApiClient.ApiClient(apiKey, appSid, True)
emailApi = EmailApi(api_client);

#set input file name
name =  "email_test.eml";
propertyName = "Subject"

body = EmailProperty.EmailProperty()
body.Name = "Subject"
body.Value = "This is a new subject"

try:
    #upload file to aspose cloud storage
    response = storageApi.PutCreate(name, data_folder + name)

    #invoke Aspose.Email Cloud SDK API to update an email property by name
    response = emailApi.PutSetEmailProperty(name, propertyName, body)

    if(response.Status == 'OK'):
        print "Property Name :: " + response.EmailProperty.Name
        print "Property Value :: " + response.EmailProperty.Value

except ApiException as ex:
            print "ApiException:"
            print "Code:" + str(ex.code)
            print "Message:" + ex.message
