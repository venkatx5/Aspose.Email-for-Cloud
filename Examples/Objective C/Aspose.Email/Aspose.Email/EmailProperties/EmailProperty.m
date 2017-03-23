//
//  EmailProperty.m
//  Aspose.Email
//
//  Created by Muhammad Sohail Ismail on 12/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "EmailProperty.h"
#import "ASPEmailApi.h"
#import "Utils.h"

@implementation EmailProperty

- (id)init {
    self = [super init];
    
    self.emailApi = [[ASPEmailApi alloc] init];
    
    return self;
}

- (void)getDocument {
//ExStart:GetDocument
    NSString *fileName = @"email_test.eml";
    [Utils uploadFile:fileName];
    
    [self.emailApi getDocumentWithCompletionBlock:fileName
                                          storage:nil
                                           folder:nil
                                completionHandler:^(NSURL *output, NSError *error) {
                                    NSLog(@"%@", output);
                                }];
//ExEnd:GetDocument
}

- (void)getEmailProperty {
//ExStart:GetEmailProperty
    NSString *fileName = @"email_test.eml";
    [Utils uploadFile:fileName];
    
    [self.emailApi getEmailPropertyWithCompletionBlock:@"Subject"
                                                  name:fileName
                                               storage:nil
                                                folder:nil
                                     completionHandler:^(ASPEmailPropertyResponse *output, NSError *error) {
                                         NSLog(@"%@", output);
                                     }];
//ExEnd:GetEmailProperty
}

- (void)putSetEmailProperty {
//ExStart:PutSetEmailProperty
    
    NSString *fileName = @"email_test.eml";
    [Utils uploadFile:fileName];
    
    ASPEmailPropertyWithStringValue *emailProperty = [[ASPEmailPropertyWithStringValue alloc] init];
    emailProperty.name = @"Subject";
    emailProperty.value = @"This is a new subject";
    
    [self.emailApi putSetEmailPropertyWithCompletionBlock:fileName
                                             propertyName:@"Subject"
                                                _property:emailProperty
                                                  storage:nil
                                                   folder:nil
                                        completionHandler:^(ASPEmailPropertyResponse *output, NSError *error) {
                                            NSLog(@"%@", output);
                                        }];
//ExEnd:PutSetEmailProperty
}

@end
