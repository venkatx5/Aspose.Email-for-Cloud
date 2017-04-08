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
import com.aspose.email.model.EmailProperty;
import com.aspose.email.model.EmailPropertyResponse;
import com.aspose.storage.api.StorageApi;

public class SetMessagePropertyExample {

	public static void execute(Context context) {
		//ExStart: SetMessagePropertyExample
		String fileName = "emailtest.eml";
		String propertyName = "Subject";
		String storage = "";
		String folder = "";

		EmailProperty emailSubject = new EmailProperty();
		emailSubject.setName ( "Subject");
		emailSubject.setValue ( "This is a new subject");

		try
		{
			File inputFile = Utils.stream2file("email_test","eml", context.getResources().openRawResource(R.raw.emailtest));

			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			EmailApi emailApi = new EmailApi(Configuration.apiKey, Configuration.appSID, true);
		    // Upload source file to aspose cloud storage
		    storageApi.PutCreate(fileName, "", "",inputFile);

		    // Invoke Aspose.Email Cloud SDK API to set message property
		    EmailPropertyResponse apiResponse = emailApi.PutSetEmailProperty(fileName, propertyName, storage, folder, emailSubject);

		    if (apiResponse != null)
		    {
		    	System.out.println("Property Name :: " + apiResponse.getEmailProperty().getName());
		        System.out.println("Property Value :: " + apiResponse.getEmailProperty().getValue());
		        System.out.println("Set Message Property, Done!");
		    }
		}
		catch (Exception ex)
		{
		    ex.printStackTrace();
		}
		//ExEnd: SetMessagePropertyExample
	}

}
