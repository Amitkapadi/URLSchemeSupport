//
//  URLSchemeSupport.m
//  ARLauncher
//
//  Created by Christopher Baltzer on 2012-10-15.
//  Copyright (c) 2012 Ad-Dispatch. All rights reserved.
//

#import "URLSchemeSupport.h"

@implementation URLSchemeSupport


+(BOOL) isURLSchemeSupported:(NSString *)urlScheme {
    if ([[UIApplication sharedApplication] canOpenURL:[NSURL URLWithString:urlScheme]]) {
        return YES;
    } else {
        return NO;
    }
        
}

@end


extern "C" {
    
    bool _isURLSchemeSupported(const char * urlScheme) {
        return [URLSchemeSupport isURLSchemeSupported:[NSString stringWithUTF8String:urlScheme]];
    }
    
    
}