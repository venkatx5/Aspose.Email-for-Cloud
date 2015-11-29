//
//  ASPEmailPropertiesWithStringValue.h
//  Aspose.Email_Cloud_SDK_For_Objective_C
//
//  Created by Muhammad Sohail Ismail on 29/11/2015.
//  Copyright © 2015 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "ASPObject.h"
#import "ASPEmailPropertyWithStringValue.h"
#import "ASPLink.h"

@protocol ASPEmailPropertiesWithStringValue
@end

@interface ASPEmailPropertiesWithStringValue : ASPObject

@property(nonatomic) ASPLink* link;
@property(nonatomic) NSArray<ASPEmailPropertyWithStringValue>* list;

@end
