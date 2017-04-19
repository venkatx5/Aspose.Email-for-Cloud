package com.aspose.email.cloud.examples.working.attachments;
import android.content.Context;

import java.io.File;


import com.aspose.email.api.EmailApi;
import com.aspose.email.cloud.R;
import com.aspose.email.cloud.examples.Configuration;
import com.aspose.email.cloud.Utils;
import com.aspose.email.cloud.examples.working.ConvertEmailOtherFormats;
import com.aspose.email.model.ResponseMessage;
import com.aspose.storage.api.StorageApi;

public class DownloadAttacmentFromEmail {

	public static void execute(Context context) {

		//ExStart: DownloadAttacmentFromEmail
		/*
		String fileName = "emailtest.eml";
		String attachName = "readme.txt";
		String storage = "";
		String folder = "";


		try
		{
			File inputFile = Utils.stream2file("email_test","eml", context.getResources().openRawResource(R.raw.emailtest));
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);
			// Instantiate Aspose Words API SDK
			EmailApi emailApi = new EmailApi(Configuration.apiKey, Configuration.appSID, true);
		    // Upload source file to aspose cloud storage
		    storageApi.PutCreate(fileName, "", "", inputFile);

		    // Invoke Aspose.Email Cloud SDK API to download attachment from email
		    ResponseMessage apiResponse = emailApi.GetEmailAttachment(fileName, attachName, storage, folder);

		    if (apiResponse != null)
		    {
				Utils.copyInputStreamToFile(apiResponse.getInputStream(),inputFile);
				System.out.println("Download Attachment from Email, Done!");
		    }
		}
		catch (Exception ex)
		{
		    ex.printStackTrace();
		}
		*/
		//ExEnd: DownloadAttacmentFromEmail
	}

}
