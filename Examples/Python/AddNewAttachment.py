import asposeemailcloud
from asposeemailcloud.EmailApi import EmailApi
from asposeemailcloud.EmailApi import ApiException

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
name =  "email_test.eml"
attachName = "README.TXT"

try:
    #upload file to aspose cloud storage
    response = storageApi.PutCreate(name, data_folder + name)
    response = storageApi.PutCreate(attachName, data_folder + attachName)

    #invoke Aspose.Email Cloud SDK API to add attachment to a message
    response = emailApi.PostAddEmailAttachment(name, attachName)

    if(response.Status == 'OK'):
        #download email from cloud storage
        response = storageApi.GetDownload(Path=name)
        outfilename = "c:/temp/" + name
        with open(outfilename, 'wb') as f:
                    for chunk in response.InputStream:
                        f.write(chunk)
except ApiException as ex:
            print "ApiException:"
            print "Code:" + str(ex.code)
            print "Message:" + ex.message

