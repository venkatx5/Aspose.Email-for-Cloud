Pod::Spec.new do |s|
  s.name         = "AsposeEmailCloud"
  s.version      = "1.0.0"
  s.summary      = "Aspose.Email for Cloud"
  s.description  = <<-DESC
                   Aspose.Email for Cloud is a REST API for creating email archiving applications that work with common email file formats. It lets developers manipulate message formats such as MSG, EML, and MHT files. The API supports many common tasks, for example accessing messages, reading message properties such as sender, receiver, message sent date, and message details. It also supports converting messages back and forth between EML, MSG and MHT formats. With Aspose.Email for Cloud, it is further possible to access messages and retrieve attachments that can then be saved to a local disc. The robust API saves developers time and effort when programming with emails in the cloud. 
                   DESC

  s.homepage     = "http://www.aspose.com/cloud/email-api.aspx"
  s.license = { :type => 'MIT', :file => 'LICENSE'}
  s.author = { "M. Sohail Ismail" => "muhammad.sohail@aspose.com" }
  s.social_media_url = "https://www.facebook.com/asposeplugins/"
  s.platform = :ios, "7.0"
  s.source       = { :git => "https://github.com/asposeemail/Aspose_Email_Cloud.git", :tag => "1.0.0" }
  
  s.subspec 'model' do |ss|
      ss.source_files = 'SDKs/Aspose.Email_Cloud_SDK_For_Objective_C/Aspose.Email_Cloud_SDK_For_Objective_C/email/model/*.{h,m}'
  end
  s.subspec 'api' do |ss|
      ss.dependency 'AsposeEmailCloud/model'
      ss.source_files = 'SDKs/Aspose.Email_Cloud_SDK_For_Objective_C/Aspose.Email_Cloud_SDK_For_Objective_C/email/api/*.{h,m}'
  end
  
  s.dependency "AFNetworking", "~> 2.0"
  s.dependency "JSONModel", "~> 1.1"
  s.dependency "ISO8601", "~> 0.3"
  s.dependency "AsposeStorageCloud"

  s.requires_arc = true

end