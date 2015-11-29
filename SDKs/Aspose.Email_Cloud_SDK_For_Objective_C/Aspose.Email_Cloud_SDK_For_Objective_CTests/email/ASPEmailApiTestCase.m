//
//  ASPEmailApiTestCase.m
//  Aspose.Email_Cloud_SDK_For_Objective_C
//
//  Created by Muhammad Sohail Ismail on 24/11/2015.
//  Copyright © 2015 Aspose. All rights reserved.
//

#import <XCTest/XCTest.h>
#import "ASPEmailApi.h"
#import "ASPStorageApi.h"
#import "AppDelegate.h"

@interface ASPEmailApiTestCase : XCTestCase
@property(nonatomic, strong) ASPEmailApi *emailApi;
@end

@implementation ASPEmailApiTestCase

- (void)setUp {
    [super setUp];
    // Put setup code here. This method is called before the invocation of each test method in the class.
    self.emailApi = [[ASPEmailApi alloc] init];
    //Get App key and App SID from https://cloud.aspose.com
    [ASPApiClient setAppKey:ASPAppKey andAppSID:ASPAppSID];
}

- (void)tearDown {
    // Put teardown code here. This method is called after the invocation of each test method in the class.
    [super tearDown];
}

- (void)uploadFile:(NSString *) fileName {
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPStorageApi *storageApi = [[ASPStorageApi alloc] init];
    
    NSURL *pathToFile = [[NSBundle mainBundle] URLForResource:[fileName stringByDeletingPathExtension] withExtension:[fileName pathExtension]];
    [storageApi putCreateWithCompletionBlock:fileName
                                        file:pathToFile
                                   versionId:nil
                                     storage:nil
                           completionHandler:^(ASPBaseResponse *output, NSError *error) {
                               XCTAssertNotNil(output, @"Failed to upload a specific file.");
                               [expectation fulfill];
                           }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocument {
    
    NSString *fileName = @"email_test.eml";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.emailApi getDocumentWithCompletionBlock:fileName
                                          storage:nil
                                           folder:nil
                                completionHandler:^(NSURL *output, NSError *error) {
                                             XCTAssertNotNil(output, @"Failed to get mail common info.");
                                             [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetDocumentWithFormat {
    
    NSString *fileName = @"email_test.eml";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.emailApi getDocumentWithFormatWithCompletionBlock:fileName
                                                     format:@"msg"
                                                    outPath:nil
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(NSURL *output, NSError *error) {
                                              XCTAssertNotNil(output, @"Failed to get mail in specified format");
                                              [expectation fulfill];
     }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPutCreateNewEmail {
    
    NSString *fileName = @"email_test2.eml";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPEmailDocumentWithStringValue *emailDocument = [[ASPEmailDocumentWithStringValue alloc] init];
    
    ASPEmailPropertyWithStringValue *emailBody = [[ASPEmailPropertyWithStringValue alloc] init];
    ASPEmailPropertyWithStringValue *emailTo = [[ASPEmailPropertyWithStringValue alloc] init];
    ASPEmailPropertyWithStringValue *emailFrom = [[ASPEmailPropertyWithStringValue alloc] init];
    
    emailBody.name = @"Body";
    emailBody.value = @"This is body";
    
    emailTo.name = @"To";
    emailTo.value = @"developer@aspose.com";
    
    emailFrom.name = @"From";
    emailFrom.value = @"sales@aspose.com";
    
    ASPEmailPropertiesWithStringValue *emailProperties = [[ASPEmailPropertiesWithStringValue alloc] init];
    emailProperties.list = (NSArray<ASPEmailPropertyWithStringValue> *) @[emailBody, emailTo, emailFrom];
    
    emailDocument.documentProperties = emailProperties;
    emailDocument.format = @"eml";
    
    [self.emailApi putCreateNewEmailWithCompletionBlock:fileName
                                                  email:emailDocument
                                                storage:nil
                                                 folder:nil
                                      completionHandler:^(ASPEmailDocumentResponse *output, NSError *error) {
                                          XCTAssertNotNil(output, @"Failed to add new email.");
                                          [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetEmailAttachment {
    
    NSString *fileName = @"email_test2.eml";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.emailApi getEmailAttachmentWithCompletionBlock:fileName
                                              attachName:@"README.TXT"
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(NSURL *output, NSError *error) {
                                           XCTAssertNotNil(output, @"Failed to get email attachment by name.");
                                           [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPostAddEmailAttachment {
    
    NSString *fileName = @"email_test.eml";
    [self uploadFile:fileName];
    NSString *attachName = @"README.TXT";
    [self uploadFile:attachName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.emailApi postAddEmailAttachmentWithCompletionBlock:fileName
                                                  attachName:attachName
                                                     storage:nil
                                                      folder:nil
                                           completionHandler:^(ASPEmailDocumentResponse *output, NSError *error) {
                                               XCTAssertNotNil(output, @"Failed to add email attachment.");
                                               [expectation fulfill];
     }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testGetEmailProperty {
    
    NSString *fileName = @"email_test.eml";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    [self.emailApi getEmailPropertyWithCompletionBlock:@"Body"
                                                  name:fileName
                                               storage:nil
                                                folder:nil
                                     completionHandler:^(ASPEmailPropertyResponse *output, NSError *error) {
                                         XCTAssertNotNil(output, @"Failed to read document property by name.");
                                         [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

- (void)testPutSetEmailProperty {
    
    NSString *fileName = @"email_test.eml";
    [self uploadFile:fileName];
    
    XCTestExpectation *expectation = [self expectationWithDescription:@""];
    
    ASPEmailPropertyWithStringValue *emailProperty = [[ASPEmailPropertyWithStringValue alloc] init];
    emailProperty.name = @"Subject";
    emailProperty.value = @"This is a new subject";
    
    [self.emailApi putSetEmailPropertyWithCompletionBlock:fileName
                                             propertyName:@"Subject"
                                                _property:emailProperty
                                                  storage:nil
                                                   folder:nil
                                        completionHandler:^(ASPEmailPropertyResponse *output, NSError *error) {
                                            XCTAssertNotNil(output, @"Failed to set document property.");
                                            [expectation fulfill];
    }];
    
    [self waitForExpectationsWithTimeout:180.0 handler:^(NSError *error) {
        if (error) {
            NSLog(@"Timeout Error: %@", error);
        }
    }];
}

@end
