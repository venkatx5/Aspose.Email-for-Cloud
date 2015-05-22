<?php

namespace Aspose\Email;

use Aspose\Email\ApiException as Exception;
use Aspose\Email\ApiClient;

class EmailApi {

    function __construct() {
        $this->apiClient = new ApiClient();
    }

    /**
     * GetDocument
     * Get mail common info.
     * name, string: File name. (required)

     * storage, string: The document storage. (optional)

     * folder, string: Folder path. (optional)

     * @return ResponseMessage
     */
    public function GetDocument($name, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/email/{name}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/octet-stream';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ResponseMessage');
        return $responseObject;
    }

    /**
     * GetDocumentWithFormat
     * Convert mail message to target format.
     * name, string: File name. (required)

     * format, string: Target format. (required)

     * storage, string: The document storage. (optional)

     * folder, string: Folder path. (optional)

     * outPath, string: Path to save result (optional)

     * @return ResponseMessage
     */
    public function GetDocumentWithFormat($name, $format, $storage = null, $folder = null, $outPath = null) {
        // verify required params are set
        if ($name == '' || $format == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/email/{name}/?appSid={appSid}&amp;toFormat={toFormat}&amp;storage={storage}&amp;folder={folder}&amp;outPath={outPath}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/octet-stream';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($format != null) {
            $resourcePath = str_replace("{" . "format" . "}", $this->apiClient->toQueryValue($format), $resourcePath);
        } else {
            $resourcePath = str_replace("&format={" . "format" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        if ($outPath != null) {
            $resourcePath = str_replace("{" . "outPath" . "}", $this->apiClient->toQueryValue($outPath), $resourcePath);
        } else {
            $resourcePath = str_replace("&outPath={" . "outPath" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ResponseMessage');
        return $responseObject;
    }

    /**
     * GetEmailAttachment
     * Get email attachment by name.
     * name, string: The email message name. (required)

     * attachName, string: Attachment name. (required)

     * storage, string: Message storage. (optional)

     * folder, string: Message folder. (optional)

     * @return ResponseMessage
     */
    public function GetEmailAttachment($name, $attachName, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $attachName == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/email/{name}/attachments/{attachName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/octet-stream';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($attachName != null) {
            $resourcePath = str_replace("{" . "attachName" . "}", $this->apiClient->toQueryValue($attachName), $resourcePath);
        } else {
            $resourcePath = str_replace("&attachName={" . "attachName" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ResponseMessage');
        return $responseObject;
    }

    /**
     * GetEmailProperty
     * Read document property by name.
     * propertyName, string: Name of document property (required)

     * name, string: File name (required)

     * storage, string: The document storage. (optional)

     * folder, string: Folder path (optional)

     * @return ResponseMessage
     */
    public function GetEmailProperty($propertyName, $name, $storage = null, $folder = null) {
        // verify required params are set
        if ($propertyName == '' || $name == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/email/{name}/properties/{propertyName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "GET";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/octet-stream';
        $headerParams['Content-Type'] = 'application/json';

        if ($propertyName != null) {
            $resourcePath = str_replace("{" . "propertyName" . "}", $this->apiClient->toQueryValue($propertyName), $resourcePath);
        } else {
            $resourcePath = str_replace("&propertyName={" . "propertyName" . "}", "", $resourcePath);
        }
        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'ResponseMessage');
        return $responseObject;
    }

    /**
     * PostAddEmailAttachment
     * Add email attachment.
     * name, string: Email name. (required)

     * attachName, string: Attachment path. (required)

     * storage, string: Email's storage. (optional)

     * folder, string: Email's folder. (optional)

     * @return EmailDocumentResponse
     */
    public function PostAddEmailAttachment($name, $attachName, $storage = null, $folder = null) {
        // verify required params are set
        if ($name == '' || $attachName == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/email/{name}/attachments/{attachName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "POST";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($attachName != null) {
            $resourcePath = str_replace("{" . "attachName" . "}", $this->apiClient->toQueryValue($attachName), $resourcePath);
        } else {
            $resourcePath = str_replace("&attachName={" . "attachName" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'EmailDocumentResponse');
        return $responseObject;
    }

    /**
     * PutCreateNewEmail
     * Add new email.
     * name, string: The email name. (required)

     * storage, string: The document storage. (optional)

     * folder, string: The email folder. (optional)

     * body, EmailDocument: Email data. (required)

     * @return EmailDocumentResponse
     */
    public function PutCreateNewEmail($name, $storage = null, $folder = null, $body) {
        // verify required params are set
        if ($name == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/email/{name}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "PUT";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'EmailDocumentResponse');
        return $responseObject;
    }

    /**
     * PutSetEmailProperty
     * Set document property.
     * name, string:  (required)

     * propertyName, string:  (required)

     * storage, string:  (optional)

     * folder, string:  (optional)

     * body, EmailProperty:  (required)

     * @return EmailPropertyResponse
     */
    public function PutSetEmailProperty($name, $propertyName, $storage = null, $folder = null, $body) {
        // verify required params are set
        if ($name == '' || $propertyName == '' || $body == '') {
            throw new Exception("missing required params");
        }
        //parse inputs
        $resourcePath = "/email/{name}/properties/{propertyName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}";
        //$resourcePath = str_replace("{format}", "json", $resourcePath);
        $resourcePath = str_replace("toFormat={toFormat}", "format={format}", str_replace("/?", "?", str_replace("&amp;", "&", str_replace("\\*", "", $resourcePath))));
        $method = "PUT";
        $queryParams = array();
        $headerParams = array();
        $headerParams['Accept'] = 'application/xml,application/json';
        $headerParams['Content-Type'] = 'application/json';

        if ($name != null) {
            $resourcePath = str_replace("{" . "name" . "}", $this->apiClient->toQueryValue($name), $resourcePath);
        } else {
            $resourcePath = str_replace("&name={" . "name" . "}", "", $resourcePath);
        }
        if ($propertyName != null) {
            $resourcePath = str_replace("{" . "propertyName" . "}", $this->apiClient->toQueryValue($propertyName), $resourcePath);
        } else {
            $resourcePath = str_replace("&propertyName={" . "propertyName" . "}", "", $resourcePath);
        }
        if ($storage != null) {
            $resourcePath = str_replace("{" . "storage" . "}", $this->apiClient->toQueryValue($storage), $resourcePath);
        } else {
            $resourcePath = str_replace("&storage={" . "storage" . "}", "", $resourcePath);
        }
        if ($folder != null) {
            $resourcePath = str_replace("{" . "folder" . "}", $this->apiClient->toQueryValue($folder), $resourcePath);
        } else {
            $resourcePath = str_replace("&folder={" . "folder" . "}", "", $resourcePath);
        }
        //make the API Call
        if (!isset($body)) {
            $body = null;
        }
        if (isset($file)) {
            $body = $file;
        }
        $response = $this->apiClient->callAPI($resourcePath, $method, $queryParams, $body, $headerParams);

        if (!$response) {
            return null;
        }

        $responseObject = $this->apiClient->deserialize($response, 'EmailPropertyResponse');
        return $responseObject;
    }

}
