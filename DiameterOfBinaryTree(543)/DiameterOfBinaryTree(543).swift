//
//  TreeDiameter.swift
//
//  Created by Martin Honzatko on 2023-08-02.
//

import Foundation

func getTreeDiameter() {
	struct Edge { let to, dist: Int; init(_ to: Int, _ dist: Int) { self.to = to; self.dist = dist } }
	
	func bfs(x: Int, _ visited: inout [Bool], dist: inout [Int], _ adj: inout [[Edge]]) {
		let q = Queue<Int>()
		visited[x - 1] = true
		q.enqueue(x)
		while !q.isEmpty() {
			let u = q.dequeue()!
			for e in adj[u - 1] {
				if !visited[e.to - 1] {
					dist[e.to - 1] = dist[u - 1] + e.dist
					q.enqueue(e.to)
					visited[e.to - 1] = true
				}
			}
		}
	}
	
	let n = Int(readLine()!)!
	var adj = [[Edge]](repeating: [], count: n)
	var visited = [Bool](repeating: false, count: n), visited1 = visited
	var dists = [Int](repeating: 0, count: n), dists1 = dists
	
	for _ in 0..<n {
		let line = readLine()!.split(separator: " ").map { Int($0)! }, from = line[0]
		for j in stride(from: 1, to: line.count - 2, by: 2) {
			let to = line[j], dist = line[j + 1]
			adj[from - 1].append(Edge(to, dist))
		}
	}
	
	var start = 1
	bfs(x: start, &visited, dist: &dists, &adj)
	for i in 1..<n { if dists[i] > dists[start - 1] { start = i + 1 } }
	bfs(x: start, &visited1, dist: &dists1, &adj)
	
	print(dists1.max()!)
}
