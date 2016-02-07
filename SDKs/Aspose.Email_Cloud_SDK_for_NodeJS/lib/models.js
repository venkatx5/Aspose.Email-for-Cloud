exports.models = {
  "HttpStatusCode": {
  "id" : "HttpStatusCode"
},"TextEffect": {
  "id" : "TextEffect"
},"PageBorderAppliesTo": {
  "id" : "PageBorderAppliesTo"
},"Orientation": {
  "id" : "Orientation"
},"EmailProperties": {
  "properties" : {
    "Link" : {
      "$ref" : "Link"
    },
    "List" : {
      "type" : "array",
      "items" : {
        "$ref" : "EmailProperty"
      }
    }
  },
  "id" : "EmailProperties"
},"EmailDocument": {
  "properties" : {
    "Links" : {
      "type" : "array",
      "items" : {
        "$ref" : "Link"
      }
    },
    "DocumentProperties" : {
      "$ref" : "EmailProperties"
    },
    "Data" : {
      "$ref" : "System.IO.Stream"
    },
    "Format" : {
      "type" : "string"
    }
  },
  "id" : "EmailDocument"
},"PageVerticalAlignment": {
  "id" : "PageVerticalAlignment"
},"NumberStyle": {
  "id" : "NumberStyle"
},"StyleIdentifier": {
  "id" : "StyleIdentifier"
},"PageBorderDistanceFrom": {
  "id" : "PageBorderDistanceFrom"
},"ResponseMessage": {
  "properties" : {
    "Code" : {
      "$ref" : "int"
    },
    "Message" : {
      "type" : "string"
    }
  },
  "id" : "ResponseMessage"
},"LineNumberRestartMode": {
  "id" : "LineNumberRestartMode"
},"PaperSize": {
  "id" : "PaperSize"
},"Link": {
  "properties" : {
    "Href" : {
      "type" : "string"
    },
    "Rel" : {
      "type" : "string"
    },
    "Type" : {
      "type" : "string"
    },
    "Title" : {
      "type" : "string"
    }
  },
  "id" : "Link"
},"ReportType": {
  "id" : "ReportType"
},"Underline": {
  "id" : "Underline"
},"SectionStart": {
  "id" : "SectionStart"
},"EmailPropertyResponse": {
  "properties" : {
    "EmailProperty" : {
      "$ref" : "EmailProperty"
    },
    "Code" : {
      "type" : "string"
    },
    "Status" : {
      "type" : "string"
    }
  },
  "id" : "EmailPropertyResponse"
},"HttpResponseMessage": {
  "properties" : {
    "Content" : {
      "type" : "string"
    },
    "Headers" : {
      "type" : "string"
    },
    "IsSuccessStatusCode" : {
      "$ref" : "bool"
    },
    "ReasonPhrase" : {
      "type" : "string"
    },
    "RequestMessage" : {
      "type" : "string"
    },
    "StatusCode" : {
      "type" : "string"
    },
    "Version" : {
      "type" : "string"
    }
  },
  "id" : "HttpResponseMessage"
},"EmailProperty": {
  "properties" : {
    "Link" : {
      "$ref" : "Link"
    },
    "Name" : {
      "type" : "string"
    },
    "Value" : {
      "type" : "object"
    }
  },
  "id" : "EmailProperty"
},"EmailDocumentResponse": {
  "properties" : {
    "Link" : {
      "$ref" : "Link"
    },
    "Properties" : {
      "type" : "array",
      "items" : {
        "$ref" : "EmailProperty"
      }
    },
    "Document" : {
      "$ref" : "EmailDocument"
    },
    "Code" : {
      "type" : "string"
    },
    "Status" : {
      "type" : "string"
    }
  },
  "id" : "EmailDocumentResponse"
}
}