require 'aspose_storage_cloud'

# Common files
require_relative 'aspose_email_cloud/api_client'
require_relative 'aspose_email_cloud/api_error'
require_relative 'aspose_email_cloud/version'
require_relative 'aspose_email_cloud/configuration'

# Models
require_relative 'aspose_email_cloud/models/base_object'
require_relative 'aspose_email_cloud/models/base_response'
require_relative 'aspose_email_cloud/models/email_document'
require_relative 'aspose_email_cloud/models/email_properties'
require_relative 'aspose_email_cloud/models/stream'
require_relative 'aspose_email_cloud/models/email_property'
require_relative 'aspose_email_cloud/models/email_document_response'
require_relative 'aspose_email_cloud/models/email_property_response'
require_relative 'aspose_email_cloud/models/link'

# APIs
require_relative 'aspose_email_cloud/api/email_api'

module AsposeEmailCloud
  class << self
    # Configure sdk using block.
    # AsposeEmailCloud.configure do |config|
    #   config.username = "xxx"
    #   config.password = "xxx"
    # end
    # If no block given, return the configuration singleton instance.
    def configure
      if block_given?
        yield Configuration.instance
      else
        Configuration.instance
      end
    end
  end
end
