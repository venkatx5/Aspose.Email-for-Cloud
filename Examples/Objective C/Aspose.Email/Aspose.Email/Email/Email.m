//
//  Email.m
//  Aspose.Email
//
//  Created by Muhammad Sohail Ismail on 12/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "Email.h"
#import "ASPEmailApi.h"
#import "Utils.h"

@implementation Email

- (id)init {
    self = [super init];
    
    self.emailApi = [[ASPEmailApi alloc] init];
    
    return self;
}

- (void)getDocumentWithFormat {
//ExStart:GetDocumentWithFormat
    NSString *fileName = @"email_test.eml";
    //[Utils uploadFile:fileName];
    
   [self.emailApi getDocumentWithFormatWithCompletionBlock:fileName
                                                     format:@"msg"
                                                    outPath:nil
                                                    storage:nil
                                                     folder:nil
                                          completionHandler:^(NSURL *output, NSError *error) {
                                              NSLog(@"%@", output);
                                          }];
//ExEnd:GetDocumentWithFormat
}

- (void)putCreateNewEmail {
//ExStart:PutCreateNewEmail
    NSString *fileName = @"email_test2.eml";
    //[Utils uploadFile:fileName];
    
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
                                          NSLog(@"%@", output);
                                      }];
//ExEnd:PutCreateNewEmail
}

@end
