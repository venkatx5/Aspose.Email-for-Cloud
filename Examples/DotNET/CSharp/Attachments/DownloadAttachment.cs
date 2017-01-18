using System;
using Com.Aspose.Email.Api;
using Com.Aspose.Email.Model;
using Com.Aspose.Storage.Api;

namespace Attachments
{
    class DownloadAttachment
    {
        public static void Run()
        {
            // ExStart:1
            EmailApi emailApi = new EmailApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            String fileName = "email_test2.eml";
            String attachName = "README.TXT";
            String storage = "";
            String folder = "";

            try
            {
                // Upload source file to aspose cloud storage
                storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));

                // Invoke Aspose.Email Cloud SDK API to download attachment from email
                ResponseMessage apiResponse = emailApi.GetEmailAttachment(fileName, attachName, storage, folder);

                if (apiResponse != null)
                {                    
                    System.IO.File.WriteAllBytes(Common.GetDataDir() + attachName, apiResponse.ResponseStream);
                    Console.WriteLine("Download Attachment from Email, Done!");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);

            }
            // ExEnd:1
        }
    }
}
