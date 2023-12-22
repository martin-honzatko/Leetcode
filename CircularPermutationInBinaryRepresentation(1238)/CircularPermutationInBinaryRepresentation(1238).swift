//
//  CyclicPermutation.swift
//
//  Created by Martin Honzatko on 2023-07-27.
//

import Foundation

func cyclicPermutation() {
	let t = Int(readLine()!)!
	for _ in stride(from: t, to: 0, by: -1) {
		let n = Int(readLine()!)!
		var nodes = readLine()!.split(separator: " ").map { Int($0)! }
		var visited = [Bool](repeating: false, count: n), count = 0
		for v in 0..<n { if !visited[v] { dfs(start: v, nodes: &nodes, visited: &visited); count += 1 } }
		print(count)
	}
}
