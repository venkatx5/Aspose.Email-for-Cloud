using System;
using Com.Aspose.Email.Api;
using Com.Aspose.Email.Model;
using Com.Aspose.Storage.Api;

namespace Email
{
    class ConvertToOtherFormat
    {
        public static void Run()
        {
            // ExStart:1
            EmailApi emailApi = new EmailApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            String name = "email_test";
            String fileName = name + ".eml";
            String format = "msg";
            String storage = "";
            String folder = "";
            String outPath = "";

            try
            {
                // Upload source file to aspose cloud storage
                storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));

                // Invoke Aspose.Email Cloud SDK API to convert email to other formats
                ResponseMessage apiResponse = emailApi.GetDocumentWithFormat(fileName, format, storage, folder, outPath);

                if (apiResponse != null)
                {                    
                    System.IO.File.WriteAllBytes(Common.GetDataDir() + fileName, apiResponse.ResponseStream);
                    Console.WriteLine("Convert Emails to Other Formats, Done!");
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
