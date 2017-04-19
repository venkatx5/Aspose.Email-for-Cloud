package com.aspose.email.cloud.examples.working;

import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

import com.aspose.email.api.EmailApi;
import com.aspose.email.cloud.examples.Configuration;
import com.aspose.email.cloud.examples.Utils;
import com.aspose.email.model.ResponseMessage;
import com.aspose.storage.api.StorageApi;



public class ConvertEmailOtherFormats {

	public static void main(String[] args) {
		//ExStart: ConvertEmailOtherFormats
		String name = "email_test";
		String fileName = name + ".eml";
		String format = "msg";
		String storage = "";
		String folder = "";
		String outPath = "";
		Path inputFile = Utils.getPath(ConvertEmailOtherFormats.class, name);

		try
		{
			
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			EmailApi emailApi = new EmailApi(Configuration.apiKey, Configuration.appSID, true);
		    // Upload source file to aspose cloud storage
		    storageApi.PutCreate(fileName, "", "", inputFile.toFile());
		
		    // Invoke Aspose.Email Cloud SDK API to convert email to other formats
		    ResponseMessage apiResponse = emailApi.GetDocumentWithFormat(fileName, format, storage, folder, outPath);
		
		    if (apiResponse != null)
		    {
		    	Path target=Paths.get(fileName);
		    	Files.copy(apiResponse.getInputStream(), target);
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
