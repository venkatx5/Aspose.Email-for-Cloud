//
//  Attachment.h
//  Aspose.Email
//
//  Created by Muhammad Sohail Ismail on 12/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>
@class ASPEmailApi;

@interface Attachment : NSObject

@property(nonatomic, strong) ASPEmailApi *emailApi;

- (void)getEmailAttachment;
- (void)postAddEmailAttachment;

@end
