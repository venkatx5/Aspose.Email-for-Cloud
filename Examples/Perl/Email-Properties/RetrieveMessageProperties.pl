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
my $name = 'email_test.eml';
# Upload file to aspose cloud storage 
my $response = $storageApi->PutCreate(Path => $name, file => $data_path.$name);

# Invoke Aspose.Email Cloud SDK API to get email document
$response = $emailApi->GetDocument(name=> $name);

	# Display the email property info
	foreach my $emailProperty (@{$response->{'DocumentProperties'}->{'List'}}){
		print "\nName : " . $emailProperty->{'Name'} . " Value: " . $emailProperty->{'Value'};
	}
#ExEnd:1