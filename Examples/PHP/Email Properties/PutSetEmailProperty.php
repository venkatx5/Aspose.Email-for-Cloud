//ExStart:
<?php
require_once realpath(__DIR__ . '/..') . '/vendor/autoload.php';
require_once realpath(__DIR__ . '/..') . '/Utils.php';

use Aspose\Email\EmailApi;
use Aspose\Email\AsposeApp;

class EmailProperty {

	public $email;

	public function __construct() {
		AsposeApp::$appSID = Utils::appSID;
		AsposeApp::$apiKey = Utils::apiKey;
		$this->email = new EmailApi();
	}


	public function putSetEmailProperty() {
		$body = '{
                    "Link": {
                      "Href": "",
                      "Rel": "",
                      "Type": "",
                      "Title": ""
                    },
                    "Name": "CC",
                    "Value": {"info@example.com"}
                }';
		$name = 'email_test.eml';
		Utils::uploadFile($name);

		$result = $this->email->PutSetEmailProperty($name, $propertyName = "CC", $storage = "", $folder = "", $body);
		print_r($result);
	}
}

$emailProperty = new EmailProperty();
$emailProperty->putSetEmailProperty();

?>
//ExEnd:
