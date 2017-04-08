package com.aspose.email.cloud.examples.working.properties;

import android.content.Context;

import java.io.File;
import com.aspose.email.api.EmailApi;
import com.aspose.email.cloud.R;
import android.content.Context;
import java.io.File;

import com.aspose.email.api.EmailApi;
import com.aspose.email.cloud.R;
import com.aspose.email.cloud.examples.Configuration;
import com.aspose.email.cloud.Utils;
import com.aspose.email.cloud.examples.working.ConvertEmailOtherFormats;
import com.aspose.email.model.EmailDocument;
import com.aspose.email.model.EmailProperty;
import com.aspose.storage.api.StorageApi;

public class RetrieveMessagePropertiesExample {

	public static void execute(Context context) {
		//ExStart: RetrieveMessagePropertiesExample
		String fileName = "emailtest.eml";
		String storage = "";
		String folder = "";

		try
		{
			File inputFile = Utils.stream2file("email_test","eml", context.getResources().openRawResource(R.raw.emailtest));

			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			EmailApi emailApi = new EmailApi(Configuration.apiKey, Configuration.appSID, true);
		    // Upload source file to aspose cloud storage
		    storageApi.PutCreate(fileName, "", "",inputFile);

		    // Invoke Aspose.Email Cloud SDK API to get message properties
		    EmailDocument apiResponse = emailApi.GetDocument(fileName, storage, folder);

		    if (apiResponse != null)
		    {
		        for (EmailProperty emailProperty : apiResponse.getDocumentProperties().getList())
		        {

		        	System.out.println("Property Name :: " + emailProperty.getName());
		        	System.out.println("Property Value :: " + emailProperty.getValue());
		        }
		        System.out.println("Retrieve Message Properties, Done!");
		    }
		}
		catch (Exception ex)
		{
		    ex.printStackTrace();

		}
		//ExEnd: RetrieveMessagePropertiesExample
	}

}
