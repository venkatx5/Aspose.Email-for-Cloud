module AsposeEmailCloud
  # 
  class EmailDocument < BaseObject
    attr_accessor :links, :document_properties, :data, :format
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'links' => :'Links',
        
        # 
        :'document_properties' => :'DocumentProperties',
        
        # 
        :'data' => :'Data',
        
        # 
        :'format' => :'Format'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'links' => :'Array<Link>',
        :'document_properties' => :'EmailProperties',
        :'data' => :'Stream',
        :'format' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Links']
        if (value = attributes[:'Links']).is_a?(Array)
          self.links = value
        end
      end
      
      if attributes[:'DocumentProperties']
        self.document_properties = attributes[:'DocumentProperties']
      end
      
      if attributes[:'Data']
        self.data = attributes[:'Data']
      end
      
      if attributes[:'Format']
        self.format = attributes[:'Format']
      end
      
    end

  end
end
