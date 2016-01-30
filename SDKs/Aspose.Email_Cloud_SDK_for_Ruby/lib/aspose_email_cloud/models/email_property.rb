module AsposeEmailCloud
  # 
  class EmailProperty < BaseObject
    attr_accessor :link, :name, :value
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'link' => :'Link',
        
        # 
        :'name' => :'Name',
        
        # 
        :'value' => :'Value'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'link' => :'Link',
        :'name' => :'String',
        :'value' => :'Object'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Link']
        self.link = attributes[:'Link']
      end
      
      if attributes[:'Name']
        self.name = attributes[:'Name']
      end
      
      if attributes[:'Value']
        self.value = attributes[:'Value']
      end
      
    end

  end
end
