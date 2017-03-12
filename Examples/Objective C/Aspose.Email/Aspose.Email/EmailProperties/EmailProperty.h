//
//  EmailProperty.h
//  Aspose.Email
//
//  Created by Muhammad Sohail Ismail on 12/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>
@class ASPEmailApi;

@interface EmailProperty : NSObject

@property(nonatomic, strong) ASPEmailApi *emailApi;

- (void)getDocument;
- (void)getEmailProperty;
- (void)putSetEmailProperty;

@end
