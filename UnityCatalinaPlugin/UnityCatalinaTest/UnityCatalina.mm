//
//  UnityCatalina.m
//  UnityCatalinaTest
//
//  Created by Koki Ibukuro on 2019/11/08.
//  Copyright © 2019 Koki Ibukuro. All rights reserved.
//

#import <Foundation/Foundation.h>

extern "C" void _unity_hello() {
    NSLog(@"hello");
}


extern "C" int _unity_get_square_int(int i) {
    return i * i;
}
