package com.aspose.email.cloud.examples.working;

import android.content.Context;

import java.io.File;
import com.aspose.email.api.EmailApi;
import com.aspose.email.cloud.R;
import com.aspose.email.cloud.examples.Configuration;
import com.aspose.email.cloud.Utils;
import com.aspose.email.model.ResponseMessage;
import com.aspose.storage.api.StorageApi;



public class ConvertEmailOtherFormats {

	public static void execute(Context context) {
		//ExStart: ConvertEmailOtherFormats
		String name = "email_test";
		String fileName = name + ".eml";
		String format = "msg";
		String storage = "";
		String folder = "";
		String outPath = "";


		try
		{
			File inputFile = Utils.stream2file("email_test","eml", context.getResources().openRawResource(R.raw.emailtest));
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			EmailApi emailApi = new EmailApi(Configuration.apiKey, Configuration.appSID, true);
		    // Upload source file to aspose cloud storage
		    storageApi.PutCreate(fileName, "", "", inputFile);
		
		    // Invoke Aspose.Email Cloud SDK API to convert email to other formats
		    ResponseMessage apiResponse = emailApi.GetDocumentWithFormat(fileName, format, storage, folder, outPath);
		
		    if (apiResponse != null)
		    {
				File outputFile=Utils.createTempFile(name,"eml");
				Utils.copyInputStreamToFile(apiResponse.getInputStream(),outputFile);
				System.out.println("Convert Emails to Other Formats, Done!");
		    }
		}
		catch (Exception ex)
		{
		    ex.printStackTrace();
		}
		//ExEnd: ConvertEmailOtherFormats
	}

}
