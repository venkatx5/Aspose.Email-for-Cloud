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

  def get_document
    file_name = "email_test.eml"
    upload_file(file_name)

    response = @email_api.get_document(file_name)
  end

end

emailProperties = EmailProperties.new()
puts emailProperties.get_document