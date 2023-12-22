//
//  PartitionLabels.swift
//
//  Created by Martin Honzatko on 2023-08-18.
//

import Foundation

func partitionLabels(_ s: String) -> [Int] {
	guard !s.isEmpty else { return [] }
	let enumS = s.enumerated()
	var map: [Character:Int] = [:], start = 0, end = 0, result: [Int] = []
	enumS.forEach { map[$1] = $0 }
	for (i,c) in enumS {
		end = max(end, map[c] ?? -1)
		guard i == end else { continue }
		result.append(i - start + 1)
		start = (i + 1)
	}
	
	return result
}
