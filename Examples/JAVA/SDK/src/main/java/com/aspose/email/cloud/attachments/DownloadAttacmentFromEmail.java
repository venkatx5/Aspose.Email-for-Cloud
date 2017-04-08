package com.aspose.email.cloud.attachments;

import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

import com.aspose.email.api.EmailApi;
import com.aspose.email.cloud.examples.Configuration;
import com.aspose.email.cloud.examples.Utils;
import com.aspose.email.cloud.examples.working.ConvertEmailOtherFormats;
import com.aspose.email.model.ResponseMessage;
import com.aspose.storage.api.StorageApi;

public class DownloadAttacmentFromEmail {

	public static void main(String[] args) {
		//ExStart: DownloadAttacmentFromEmail
		String fileName = "email_test2.eml";
		String attachName = "README.TXT";
		String storage = "";
		String folder = "";
		Path inputFile = Utils.getPath(ConvertEmailOtherFormats.class, fileName);

		try
		{
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);
			// Instantiate Aspose Words API SDK
			EmailApi emailApi = new EmailApi(Configuration.apiKey, Configuration.appSID, true);
		    // Upload source file to aspose cloud storage
		    storageApi.PutCreate(fileName, "", "", inputFile.toFile());

		    // Invoke Aspose.Email Cloud SDK API to download attachment from email
		    ResponseMessage apiResponse = emailApi.GetEmailAttachment(fileName, attachName, storage, folder);

		    if (apiResponse != null)
		    {                    
		    	Path target=Paths.get(fileName);
		    	Files.copy(apiResponse.getInputStream(), target);
		    	System.out.println("Download Attachment from Email, Done!");
		    }
		}
		catch (Exception ex)
		{
		    ex.printStackTrace();
		}
		//ExEnd: DownloadAttacmentFromEmail
	}
}
