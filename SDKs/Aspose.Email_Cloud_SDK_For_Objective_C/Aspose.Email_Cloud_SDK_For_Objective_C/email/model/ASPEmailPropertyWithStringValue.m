//
//  ASPEmailPropertyWithStringValue.m
//  Aspose.Email_Cloud_SDK_For_Objective_C
//
//  Created by Muhammad Sohail Ismail on 29/11/2015.
//  Copyright © 2015 Aspose. All rights reserved.
//

#import "ASPEmailPropertyWithStringValue.h"

@implementation ASPEmailPropertyWithStringValue

/**
 * Maps json key to property name.
 * This method is used by `JSONModel`.
 */
+ (JSONKeyMapper *)keyMapper
{
    return [[JSONKeyMapper alloc] initWithDictionary:@{ @"Link": @"link", @"Name": @"name", @"Value": @"value" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName
{
    NSArray *optionalProperties = @[@"link", @"name", @"value"];
    
    if ([optionalProperties containsObject:propertyName]) {
        return YES;
    }
    else {
        return NO;
    }
}

/**
 * Gets the string presentation of the object.
 * This method will be called when logging model object using `NSLog`.
 */
- (NSString *)description {
    return [[self toDictionary] description];
}

@end
