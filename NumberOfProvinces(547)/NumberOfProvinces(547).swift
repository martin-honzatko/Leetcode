//
//  NumOfProvinces.swift
//
//  Created by Martin Honzatko on 2023-07-27.
//

import Foundation

func findCircleNum(_ isConnected: [[Int]]) -> Int {
	func dfs(_ start: Int, _ adjMatrix: [[Int]], _ visited: inout [Bool]) {
		visited[start] = true
		for v in 0..<adjMatrix.count {
			if start == v { continue }
			if !visited[v] && adjMatrix[start][v] == 1 {
				visited[v] = true
				dfs(v, adjMatrix, &visited)
			}
		}
	}
	
	guard isConnected.count != 0 || isConnected[0].count != 0 else { return 0 }
	let n = isConnected.count
	var visited = [Bool](repeating: false, count: n), count = 0
	for v in 0..<n { if !visited[v] { dfs(v, isConnected, &visited); count += 1 } }
	return count
}
