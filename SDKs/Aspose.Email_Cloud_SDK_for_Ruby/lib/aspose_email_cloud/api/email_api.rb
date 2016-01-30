require "uri"

module AsposeEmailCloud
  class EmailApi
    attr_accessor :api_client

    def initialize(api_client = nil)
      @api_client = api_client || Configuration.api_client
    end
    
    # Get mail common info.
    #
    # @param name File name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder Folder path.
    # @return [File]
    def get_document(name, opts = {})
        if Configuration.debugging
            Configuration.logger.debug "Calling API: EmailApi#get_document ..."
        end
        
        # verify the required parameter 'name' is set
        fail "Missing the required parameter 'name' when calling get_document" if name.nil?
        
        # resource path
        path = "/email/{name}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)
        
        # query parameters
        query_params = {}
        query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
        query_params[:'folder'] = opts[:'folder'] if opts[:'folder']
        
        # header parameters
        header_params = {}
        
        # HTTP header 'Accept' (if needed)
        _header_accept = []
        _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result
        
        # HTTP header 'Content-Type'
        _header_content_type = ['application/json']
        header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)
        
        # form parameters
        form_params = {}
        
        # http body (model)
        post_body = nil
        
        
        auth_names = []
        result = @api_client.call_api(:GET, path,
                                      :header_params => header_params,
                                      :query_params => query_params,
                                      :form_params => form_params,
                                      :body => post_body,
                                      :auth_names => auth_names,
                                      :return_type => 'File')
                                      if Configuration.debugging
                                          Configuration.logger.debug "API called: EmailApi#get_document. Result: #{result.inspect}"
                                      end
                                      return result
    end
    
    # Get mail in specified format
    # 
    # @param name File name.
    # @param format 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :out_path 
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder Folder path.
    # @return [File]
    def get_document_with_format(name, format, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: EmailApi#get_document_with_format ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_document_with_format" if name.nil?
      
      # verify the required parameter 'format' is set
      fail "Missing the required parameter 'format' when calling get_document_with_format" if format.nil?
      
      # resource path
      path = "/email/{name}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'format'] = format
      query_params[:'outPath'] = opts[:'out_path'] if opts[:'out_path']
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = []
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'File')
      if Configuration.debugging
        Configuration.logger.debug "API called: EmailApi#get_document_with_format. Result: #{result.inspect}"
      end
      return result
    end

    # Add new email.
    # 
    # @param name The email name.
    # @param email Email data.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder The email folder.
    # @return [EmailDocumentResponse]
    def put_create_new_email(name, email, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: EmailApi#put_create_new_email ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling put_create_new_email" if name.nil?
      
      # verify the required parameter 'email' is set
      fail "Missing the required parameter 'email' when calling put_create_new_email" if email.nil?
      
      # resource path
      path = "/email/{name}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json', 'text/json', 'application/xml', 'text/xml', 'text/javascript']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json', 'text/json', 'application/xml', 'text/xml', 'text/javascript', 'application/x-www-form-urlencoded']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(email)
      

      auth_names = []
      result = @api_client.call_api(:PUT, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'EmailDocumentResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: EmailApi#put_create_new_email. Result: #{result.inspect}"
      end
      return result
    end

    # Get email attachment by name.
    # 
    # @param name The email message name.
    # @param attach_name Attachment name.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage Message storage.
    # @option opts [String] :folder Message folder.
    # @return [File]
    def get_email_attachment(name, attach_name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: EmailApi#get_email_attachment ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_email_attachment" if name.nil?
      
      # verify the required parameter 'attach_name' is set
      fail "Missing the required parameter 'attach_name' when calling get_email_attachment" if attach_name.nil?
      
      # resource path
      path = "/email/{name}/attachments/{attachName}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'attachName' + '}', attach_name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = []
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = []
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'File')
      if Configuration.debugging
        Configuration.logger.debug "API called: EmailApi#get_email_attachment. Result: #{result.inspect}"
      end
      return result
    end

    # Add email attachment.
    # 
    # @param name Email name.
    # @param attach_name Attachment path.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage Email&#39;s storage.
    # @option opts [String] :folder Email&#39;s folder.
    # @return [EmailDocumentResponse]
    def post_add_email_attachment(name, attach_name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: EmailApi#post_add_email_attachment ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling post_add_email_attachment" if name.nil?
      
      # verify the required parameter 'attach_name' is set
      fail "Missing the required parameter 'attach_name' when calling post_add_email_attachment" if attach_name.nil?
      
      # resource path
      path = "/email/{name}/attachments/{attachName}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'attachName' + '}', attach_name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json', 'text/json', 'application/xml', 'text/xml', 'text/javascript']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = []
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:POST, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'EmailDocumentResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: EmailApi#post_add_email_attachment. Result: #{result.inspect}"
      end
      return result
    end

    # Read document property by name.
    # 
    # @param property_name Name of document property
    # @param name File name
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage The document storage.
    # @option opts [String] :folder Folder path
    # @return [EmailPropertyResponse]
    def get_email_property(property_name, name, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: EmailApi#get_email_property ..."
      end
      
      # verify the required parameter 'property_name' is set
      fail "Missing the required parameter 'property_name' when calling get_email_property" if property_name.nil?
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling get_email_property" if name.nil?
      
      # resource path
      path = "/email/{name}/properties/{propertyName}".sub('{format}','json').sub('{' + 'propertyName' + '}', property_name.to_s).sub('{' + 'name' + '}', name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = []
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      

      auth_names = []
      result = @api_client.call_api(:GET, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'EmailPropertyResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: EmailApi#get_email_property. Result: #{result.inspect}"
      end
      return result
    end

    # Set document property.
    # 
    # @param name 
    # @param property_name 
    # @param property 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :storage 
    # @option opts [String] :folder 
    # @return [EmailPropertyResponse]
    def put_set_email_property(name, property_name, property, opts = {})
      if Configuration.debugging
        Configuration.logger.debug "Calling API: EmailApi#put_set_email_property ..."
      end
      
      # verify the required parameter 'name' is set
      fail "Missing the required parameter 'name' when calling put_set_email_property" if name.nil?
      
      # verify the required parameter 'property_name' is set
      fail "Missing the required parameter 'property_name' when calling put_set_email_property" if property_name.nil?
      
      # verify the required parameter 'property' is set
      fail "Missing the required parameter 'property' when calling put_set_email_property" if property.nil?
      
      # resource path
      path = "/email/{name}/properties/{propertyName}".sub('{format}','json').sub('{' + 'name' + '}', name.to_s).sub('{' + 'propertyName' + '}', property_name.to_s)

      # query parameters
      query_params = {}
      query_params[:'storage'] = opts[:'storage'] if opts[:'storage']
      query_params[:'folder'] = opts[:'folder'] if opts[:'folder']

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      _header_accept = ['application/json', 'text/json', 'application/xml', 'text/xml', 'text/javascript']
      _header_accept_result = @api_client.select_header_accept(_header_accept) and header_params['Accept'] = _header_accept_result

      # HTTP header 'Content-Type'
      _header_content_type = ['application/json', 'text/json', 'application/xml', 'text/xml', 'text/javascript', 'application/x-www-form-urlencoded']
      header_params['Content-Type'] = @api_client.select_header_content_type(_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = @api_client.object_to_http_body(property)
      

      auth_names = []
      result = @api_client.call_api(:PUT, path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'EmailPropertyResponse')
      if Configuration.debugging
        Configuration.logger.debug "API called: EmailApi#put_set_email_property. Result: #{result.inspect}"
      end
      return result
    end
  end
end




