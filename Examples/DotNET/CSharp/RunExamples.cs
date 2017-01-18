using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;
using Email;
using Attachments;
using Email_Properties;

namespace CSharp
{
    class RunExamples
    {
        [STAThread]
        public static void Main()
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            // Uncomment the one you want to try out

            //// =====================================================
            //// =====================================================
            //// Email
            //// =====================================================
            //// =====================================================

            //ConvertToOtherFormat.Run();
            //AddNewEmail.Run();

            //// =====================================================
            //// =====================================================
            //// Attachments
            //// =====================================================
            //// =====================================================

            //AddAttachment.Run();
            //DownloadAttachment.Run();  

            //// =====================================================
            //// =====================================================
            //// Email-Properties
            //// =====================================================
            //// =====================================================

            //GetMessageProperty.Run();
            //RetrieveMessageProperties.Run();
            //SetMessageProperty.Run();
            
            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            Console.ReadKey();
        }
        
    }
}
