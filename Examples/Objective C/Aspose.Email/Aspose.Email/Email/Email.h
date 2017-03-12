//
//  Email.h
//  Aspose.Email
//
//  Created by Muhammad Sohail Ismail on 12/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>
@class ASPEmailApi;

@interface Email : NSObject

@property(nonatomic, strong) ASPEmailApi *emailApi;

- (void)getDocumentWithFormat;
- (void)putCreateNewEmail;

@end
