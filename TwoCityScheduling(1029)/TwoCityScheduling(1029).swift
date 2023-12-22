//
//  TwoCityScheduling.swift
//
//  Created by Martin Honzatko on 2023-08-17.
//

import Foundation

func twoCitySchedCost(_ costs: [[Int]]) -> Int {
	return costs.sorted{($0[0] - $0[1]) < ($1[0] - $1[1]) }.enumerated().reduce(0) {
		if $1.0 < (costs.count/2) { return ($0 + $1.1[0]) }
		return ($0 + $1.1[1])
	}
}
