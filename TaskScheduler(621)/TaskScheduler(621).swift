//
//  TaskScheduler.swift
//
//  Created by Martin Honzatko on 2023-08-18.
//

import Foundation

func leastInterval(_ tasks: [Character], _ n: Int) -> Int {
	guard n > 0 else { return tasks.count }
	var dict = [Character: Int](); tasks.forEach { dict[$0, default: 0] += 1 }
	let taskFreq = dict.sorted(by: { $0.value > $1.value }), maxFreq = taskFreq[0].1
	var idleTime = (maxFreq - 1)*n
	for i in 1..<taskFreq.count { idleTime -= min(maxFreq - 1, taskFreq[i].1) }
	idleTime = max(0, idleTime)
	return tasks.count + idleTime
}
