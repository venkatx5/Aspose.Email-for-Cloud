module AsposeEmailCloud
  # 
  class Stream < BaseObject
    attr_accessor :identity
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'identity' => :'identity'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'identity' => :'Object'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'identity']
        self.identity = attributes[:'identity']
      end
      
    end

  end
end
