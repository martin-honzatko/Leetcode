//
//  QueensSolver.swift
//  SwiftAGDS
//
//  Created by Derrick Park on 2019-03-13.
//  Copyright © 2019 Derrick Park. All rights reserved.
//

import Foundation

/// Write a function solveQueens that accepts a Board as a parameter
/// and tries to place 8 queens on it safely.
///
/// - Your method should stop exploring if it finds a solution
/// - You are allowed to change the function header (args or return type)
/// - Your total recursive calls should not exceed 120 times.

var count = 0
func solveQueens(board: inout Board) {
	guard board.size > 0 else { return }
	var colums = Array(repeating: 0, count: board.size).enumerated().map({$0.offset})
	var partialSolution:[Int] = []
	solveQueensHelper(board: &board, &colums,0,&partialSolution)
	print("Possible ways:\t\(count)")
}

func solveQueensHelper(board: inout Board, _ columns: inout [Int], _ subproblem: Int, _ partialSolution: inout [Int]) {
	func canPutQueen(_ pick: Int) -> Bool {
		for (row,column) in partialSolution.enumerated() {
			if (pick == column) || abs(row - subproblem) == abs(pick - column ) { return false }
		}
		
		return true
	}
	
	if subproblem == columns.count {
		var r = 0
		for e in partialSolution {
			board.place(row: e, col: r)
			r += 1
		}
		
		print(board)
		count += 1
		
		r = 0
		for e in partialSolution {
			board.remove(row: e, col: r)
			r += 1
		}
	}
	
	for pick in subproblem..<columns.count {
		columns.swapAt(pick, subproblem)
		if canPutQueen(columns[subproblem]) {
			partialSolution.append(columns[subproblem])
			solveQueensHelper(board: &board, &columns, subproblem + 1, &partialSolution)
			partialSolution.removeLast()
		}
		
		columns.swapAt(pick, subproblem)
	}
}

func solveQueens1(board: inout Board) {
	count = 0
	guard board.size > 0 else { return }
	var colums = Array(repeating: 0, count: board.size).enumerated().map({$0.offset})
	var partialSolution:[Int] = []
	var found = false
	solveQueens1Helper(board: &board, &colums,0,&partialSolution, found: &found)
	print("Possible ways:\t\(count)")
}

func solveQueens1Helper(board: inout Board, _ columns: inout [Int], _ subproblem: Int, _ partialSolution: inout [Int], found: inout Bool) {
	func canPutQueen(_ pick: Int) -> Bool {
		for (row,column) in partialSolution.enumerated() {
			if (pick == column) || abs(row - subproblem) == abs(pick - column ) { return false }
		}
		
		return true
	}
	
	count += 1
	var found = found
	if subproblem == columns.count && found == false {
		var r = 0
		for e in partialSolution {
			board.place(row: e, col: r)
			r += 1
		}
		
		print(board)
		found = true
	}
	
	if found == false {
		for pick in subproblem..<columns.count {
			columns.swapAt(pick, subproblem)
			if canPutQueen(columns[subproblem]) {
				partialSolution.append(columns[subproblem])
				solveQueens1Helper(board: &board, &columns, subproblem + 1, &partialSolution, found: &found)
				partialSolution.removeLast()
			}
			
			columns.swapAt(pick, subproblem)
		}
	} else {
		return
	}
}

func solveNQueens(_ n: Int) -> [[String]] {
	var res = [[Int]]()

	func backtrack(_ p: [Int] = []) {
		if p.count == n { res.append(p) }
		var pth = p, avb = Set<Int>(0..<n)
		for (i,n) in pth.enumerated() {
			if let idx = avb.firstIndex(of: n - pth.count + i) { avb.remove(at: idx) }
			if let idx = avb.firstIndex(of: n) { avb.remove(at: idx) }
			if let idx = avb.firstIndex(of: n + pth.count - i) { avb.remove(at: idx) }
		}
		for i in 0..<n where avb.contains(i) {
			pth.append(i)
			backtrack(pth)
			pth.remove(at: pth.count - 1)
		}
	}
	
	backtrack()
	return res.map { $0.map { i in (0..<n).map { j in (i == j ? "Q" : ".") }.joined() }}
}
