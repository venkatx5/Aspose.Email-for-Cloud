//
//  ASPEmailDocumentWithStringValue.h
//  Aspose.Email_Cloud_SDK_For_Objective_C
//
//  Created by Muhammad Sohail Ismail on 29/11/2015.
//  Copyright © 2015 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "ASPObject.h"
#import "ASPEmailPropertiesWithStringValue.h"
#import "ASPLink.h"
#import "ASPStream.h"

@protocol ASPEmailDocumentWithStringValue
@end

@interface ASPEmailDocumentWithStringValue : ASPObject

@property(nonatomic) NSArray<ASPLink>* links;

@property(nonatomic) ASPEmailPropertiesWithStringValue* documentProperties;

@property(nonatomic) ASPStream* data;

@property(nonatomic) NSString* format;

@end
