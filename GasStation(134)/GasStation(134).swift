//
//  GasStation.swift
//
//  Created by Martin Honzatko on 2023-08-18.
//

import Foundation

func canCompleteCircuit(_ gas: [Int], _ cost: [Int]) -> Int {
	let gasCount: Int = gas.reduce(0, +), costCount: Int = cost.reduce(0, +)
	if gasCount < costCount { return -1 }
	var res: Int = 0, total: Int = 0
	
	for i in 0..<gas.count {
		total += (gas[i] - cost[i])
		if total < 0 { total = 0; res = i + 1 }
	}
	return res
}
