//
//  Attachment.m
//  Aspose.Email
//
//  Created by Muhammad Sohail Ismail on 12/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import "Attachment.h"
#import "ASPEmailApi.h"
#import "Utils.h"

@implementation Attachment

- (id)init {
    self = [super init];
    
    self.emailApi = [[ASPEmailApi alloc] init];
    
    return self;
}

- (void)getEmailAttachment {
    NSString *fileName = @"email_test2.eml";
    [Utils uploadFile:fileName];
    
    [self.emailApi getEmailAttachmentWithCompletionBlock:fileName
                                              attachName:@"README.TXT"
                                                 storage:nil
                                                  folder:nil
                                       completionHandler:^(NSURL *output, NSError *error) {
                                           NSLog(@"%@", output);
                                       }];
}

- (void)postAddEmailAttachment {
    NSString *fileName = @"email_test.eml";
    [Utils uploadFile:fileName];
    NSString *attachName = @"README.TXT";
    [Utils uploadFile:attachName];
    
    [self.emailApi postAddEmailAttachmentWithCompletionBlock:fileName
                                                  attachName:attachName
                                                     storage:nil
                                                      folder:nil
                                           completionHandler:^(ASPEmailDocumentResponse *output, NSError *error) {
                                               NSLog(@"%@", output);
                                           }];
}

@end
