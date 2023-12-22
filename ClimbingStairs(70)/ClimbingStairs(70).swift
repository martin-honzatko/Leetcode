//
//  ClimbingStairs(70).swift
//
//  Created by Martin Honzatko on 2023-12-22.
//

import Foundation

func climbStairs(_ n: Int) -> Int {
	guard n > 1 else { return 1 }
	var one: Int = 1
	var two: Int = 1
	var three: Int = 0
	
	for _ in 2...n { three = one + two; one = two; two = three }

	return two
}
