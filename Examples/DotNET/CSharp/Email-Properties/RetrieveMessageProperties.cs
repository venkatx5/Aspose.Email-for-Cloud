using System;
using Com.Aspose.Email.Api;
using Com.Aspose.Email.Model;
using Com.Aspose.Storage.Api;

namespace Email_Properties
{
    class RetrieveMessageProperties
    {
        public static void Run()
        {
            // ExStart:1
            EmailApi emailApi = new EmailApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            String fileName = "email_test.eml";
            String storage = "";
            String folder = "";

            try
            {
                // Upload source file to aspose cloud storage
                storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));

                // Invoke Aspose.Email Cloud SDK API to get message properties
                EmailDocument apiResponse = emailApi.GetDocument(fileName, storage, folder);

                if (apiResponse != null)
                {
                    foreach (EmailProperty emailProperty in apiResponse.DocumentProperties.List)
                    {

                        Console.WriteLine("Property Name :: " + emailProperty.Name);
                        Console.WriteLine("Property Value :: " + emailProperty.Value);
                    }
                    Console.WriteLine("Retrieve Message Properties, Done!");
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
