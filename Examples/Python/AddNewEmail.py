import asposeemailcloud
from asposeemailcloud.EmailApi import EmailApi
from asposeemailcloud.EmailApi import ApiException
from asposeemailcloud.models import EmailDocument
from asposeemailcloud.models import EmailProperty
from asposeemailcloud.models import Link
from asposeemailcloud.models import EmailProperties

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
name =  "email_test2.eml"

body = EmailDocument.EmailDocument()

emailBody = EmailProperty.EmailProperty()
emailTo = EmailProperty.EmailProperty()
emailFrom = EmailProperty.EmailProperty()

emailBody.Name = "Body"
emailBody.Value = "This is body"

emailTo.Name = "To"
emailTo.Value = "developer@aspose.com"

emailFrom.Name = "From"
emailFrom.Value = "sales@aspose.com"

emailProps = EmailProperties.EmailProperties()
emailProps.List = [emailBody, emailTo, emailFrom]

body.DocumentProperties = emailProps
body.Format = "eml"

try:
    #upload file to aspose cloud storage
    #response = storageApi.PutCreate(name, data_folder + name)

    #invoke Aspose.Email Cloud SDK API to add new email
    response = emailApi.PutCreateNewEmail(name, body)

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
