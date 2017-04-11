#ExStart:1
use lib 'lib';
use strict;
use warnings;
use utf8;
use File::Slurp; # From CPAN
use JSON;

use AsposeStorageCloud::StorageApi;
use AsposeStorageCloud::ApiClient;
use AsposeStorageCloud::Configuration;

use AsposeEmailCloud::EmailApi;
use AsposeEmailCloud::ApiClient;
use AsposeEmailCloud::Configuration;

use AsposeEmailCloud::Object::EmailProperty;
use AsposeEmailCloud::Object::EmailProperties;
use AsposeEmailCloud::Object::EmailDocument;

my $configFile = '../Config/config.json';
my $configPropsText = read_file($configFile);
my $configProps = decode_json($configPropsText);
my $data_path = '../../../Data/';
my $out_path = $configProps->{'out_folder'};

$AsposeEmailCloud::Configuration::app_sid = $configProps->{'app_sid'};
$AsposeEmailCloud::Configuration::api_key = $configProps->{'api_key'};
$AsposeEmailCloud::Configuration::debug = 1;

$AsposeStorageCloud::Configuration::app_sid = $configProps->{'app_sid'};
$AsposeStorageCloud::Configuration::api_key = $configProps->{'api_key'};

# Instantiate Aspose.Storage and Aspose.Email API SDK
my $storageApi = AsposeStorageCloud::StorageApi->new();
my $emailApi = AsposeEmailCloud::EmailApi->new();

# Set input file name
my $name = 'email_test2.eml';
	
my @emailProperty1 = AsposeEmailCloud::Object::EmailProperty->new('Name' => 'Body', 'Value' => 'This is a body');
my @emailProperty2 = AsposeEmailCloud::Object::EmailProperty->new('Name' => 'To', 'Value' => 'developer@aspose.com');
my @emailProperty3 = AsposeEmailCloud::Object::EmailProperty->new('Name' => 'From', 'Value' => 'sales@aspose.com');
my $emailProperties = AsposeEmailCloud::Object::EmailProperties->new('List' => [@emailProperty1, @emailProperty2, @emailProperty3]);
my $emailDocument = AsposeEmailCloud::Object::EmailDocument->new('DocumentProperties' => $emailProperties, 'Format' => 'eml');

# Upload file to aspose cloud storage 
my $response = $storageApi->PutCreate(Path => $name, file => $data_path.$name);

# Invoke Aspose.Email Cloud SDK API to add new email                         
$response = $emailApi->PutCreateNewEmail(name=> $name, body=>$emailDocument);

if($response->{'Status'} eq 'OK'){
	# Download email from cloud storage 
	my $output_file = $out_path. $name;
	$response = $storageApi->GetDownload(Path => $name);;
	write_file($output_file, { binmode => ":raw" }, $response->{'Content'});
}
#ExEnd:1