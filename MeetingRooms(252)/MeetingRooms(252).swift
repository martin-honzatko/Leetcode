//
//  MeetingRooms.swift
//
//  Created by Martin Honzatko on 2023-08-17.
//

import Foundation

func canAttendMeetings(_ intervals: [[Int]]) -> Bool {
	let interval = intervals[0][0]...intervals[0][1]
	for i in 1..<intervals.count {
		if interval.contains(intervals[i][0]) || interval.contains(intervals[i][1]) { return false }
	}
	return true
}
