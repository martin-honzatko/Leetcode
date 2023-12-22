//
//  GasStation.swift
//
//  Created by Martin Honzatko on 2023-08-18.
//

import Foundation

func canCompleteCircuit(_ gas: [Int], _ cost: [Int]) -> Int {
	guard gas.count == cost.count else { return -1 }
	var bIndex: Int = -1
	for i in 0..<gas.count { if (bIndex == -1) && ((gas[i] - cost[i]) > 0) { bIndex = i; break } }
	guard bIndex != -1 else { return -1 }
	let int0 = bIndex..<gas.count
	var int01 = [int0, 0..<0].joined()
	if bIndex != 0 {
		let int1 = 0..<bIndex
		int01 = [int0, int1].joined()
	}
	var total: Int = 0
	for i in int01 {
		let j: Int; if i == 0 { j = (gas.count - 1) } else { j = i - 1 }
		if i == bIndex { total = gas[i] } else { total -= cost[j]; total += gas[i] }
	}
	
	let j: Int; if bIndex == 0 { j = (gas.count - 1) } else { j = bIndex - 1 }
	if (total - cost[j]) >= 0 { return bIndex }
	return -1
}
