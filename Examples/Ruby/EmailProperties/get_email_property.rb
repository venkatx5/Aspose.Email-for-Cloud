require 'aspose_email_cloud'

class EmailProperties

  include AsposeEmailCloud
  include AsposeStorageCloud

  def initialize
    #Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("da77c9f5da014d91faf2961ecec2de66", "B01A15E5-1B83-4B9A-8EB3-0F2BFA6AC766")
    @email_api = EmailApi.new
  end

  def upload_file(file_name)
    @storage_api = StorageApi.new 
    response = @storage_api.put_create(file_name, File.open("../data/" << file_name,"r") { |io| io.read } )
  end

  def get_email_property
    file_name = "email_test.eml"
    upload_file(file_name)

    property_name = "Body"
    response = @email_api.get_email_property(property_name, file_name)
  end

end

emailProperties = EmailProperties.new()
puts emailProperties.get_email_property