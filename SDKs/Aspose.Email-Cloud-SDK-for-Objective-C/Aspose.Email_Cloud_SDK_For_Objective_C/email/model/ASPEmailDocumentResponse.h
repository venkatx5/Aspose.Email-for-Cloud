#import <Foundation/Foundation.h>
#import "ASPObject.h"

/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

#import "ASPEmailDocument.h"
#import "ASPEmailProperty.h"
#import "ASPLink.h"


@protocol ASPEmailDocumentResponse
@end

@interface ASPEmailDocumentResponse : ASPObject


@property(nonatomic) ASPLink* link;

@property(nonatomic) NSArray<ASPEmailProperty>* properties;

@property(nonatomic) ASPEmailDocument* document;

@property(nonatomic) NSString* code;

@property(nonatomic) NSString* status;

@end
