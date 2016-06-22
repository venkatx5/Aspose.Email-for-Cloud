module AsposeEmailCloud
  # 
  class EmailProperties < BaseObject
    attr_accessor :link, :list
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'link' => :'Link',
        
        # 
        :'list' => :'List'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'link' => :'Link',
        :'list' => :'Array<EmailProperty>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Link']
        self.link = attributes[:'Link']
      end
      
      if attributes[:'List']
        if (value = attributes[:'List']).is_a?(Array)
          self.list = value
        end
      end
      
    end

  end
end
