//
//  FindJudge.swift
//
//  Created by Martin Honzatko on 2023-07-27.
//

import Foundation

func findJudge(_ n: Int, _ trust: [[Int]]) -> Int {
	var iO = [[Int]](repeating: [Int](repeating: 0, count: 2), count: n)
	for e in trust {
		iO[e[0] - 1][1] += 1
		iO[e[1] - 1][0] += 1
	}
	
	for i in 0..<n { if (iO[i][0] == (n - 1)) && (iO[i][1] == 0) { return i + 1 } }
	return -1
}
