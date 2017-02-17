require 'aspose_email_cloud'

class EmailProperties

  include AsposeEmailCloud
  include AsposeStorageCloud

  def initialize
    #Get App key and App SID from https://cloud.aspose.com
    AsposeApp.app_key_and_sid("", "")
    @email_api = EmailApi.new
  end

  def upload_file(file_name)
    @storage_api = StorageApi.new 
    response = @storage_api.put_create(file_name, File.open("../data/" << file_name,"r") { |io| io.read } )
  end

  def put_set_email_property
    file_name = "email_test.eml"
    upload_file(file_name)
    property_name = "Subject"
    email_property = EmailProperty.new
    email_property.name = "Subject"
    email_property.value = "This is a new subject"

    response = @email_api.put_set_email_property(file_name, property_name, email_property)
  end

end

emailProperties = EmailProperties.new()
puts emailProperties.put_set_email_property