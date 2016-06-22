//
//  ASPEmailPropertyWithStringValue.h
//  Aspose.Email_Cloud_SDK_For_Objective_C
//
//  Created by Muhammad Sohail Ismail on 29/11/2015.
//  Copyright © 2015 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "ASPObject.h"
#import "ASPLink.h"

@protocol ASPEmailPropertyWithStringValue
@end

@interface ASPEmailPropertyWithStringValue : ASPObject

@property(nonatomic) ASPLink* link;
@property(nonatomic) NSString* name;
@property(nonatomic) NSString* value;

@end
