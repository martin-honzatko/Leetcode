//
//  LCA.swift
//
//  Created by Martin Honzatko on 2023-08-04.
//

import Foundation

func lca() {
	let n = Int(readLine()!)!
	var tree = [[Int]](repeating: [], count: n)
	var visited = [Bool](repeating: false, count: n)
	var depth = [Int](repeating: 0, count: n)
	var parent = [Int](repeating: 0, count: n)
	
	for _ in 0..<(n - 1) {
		let node = readLine()!.split(separator: " ").map { Int($0)! }, u = node[0], v = node[1]
		tree[u - 1].append(v)
		tree[v - 1].append(u)
	}
	
	depth[0] = 0
	visited[0] = true
	let q = Queue<Int>()
	q.enqueue(1)
	while !q.isEmpty() {
		let u = q.dequeue()!
		for v in tree[u - 1] {
			if !visited[v - 1] {
				q.enqueue(v)
				visited[v - 1] = true
				parent[v - 1] = u
				depth[v - 1] = depth[u - 1] + 1
			}
		}
	}
	
	let m = Int(readLine()!)!
	for _ in 0..<m {
		let node = readLine()!.split(separator: " ").map { Int($0)! }
		var u = node[0], v = node[1]
		if depth[u - 1] < depth[v - 1] { swap(&u, &v) }
		while depth[u - 1] != depth[v - 1] { u = parent[u - 1] }
		while u != v { u = parent[u - 1]; v = parent[v - 1] }
		print(u)
	}
}

