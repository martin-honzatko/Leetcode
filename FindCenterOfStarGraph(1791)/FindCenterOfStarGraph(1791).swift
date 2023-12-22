//
//  FindCenter.swift
//
//  Created by Martin Honzatko on 2023-07-27.
//

import Foundation

func findCenter(_ edges: [[Int]]) -> Int {
	if (edges[0][0] == edges[1][1]) || (edges[0][0] == edges[1][0]) { return edges[0][0] }
	return edges[0][1]
}
