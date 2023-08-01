# Task 

https://leetcode.com/problems/merge-intervals/ 

Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.

## Example 1:

Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].

## Example 2:

Input: intervals = [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considered overlapping.

# Approach 

1. Sort the Intervals:
Begin by sorting the array of intervals in ascending order based on the start time. This ensures that you're dealing with the intervals in the order they occur, which makes overlapping intervals easier to identify.

2. Create a Result Container:
Initialize an empty list or array to hold the merged intervals.

3. Iterate and Merge:
Iterate over the sorted intervals. For each interval, if the result container is empty or the current interval does not overlap with the last interval in the result container, add the current interval to the result container. If there is an overlap (i.e., the start of the current interval is less than or equal to the end of the last interval in the result container), merge the intervals by updating the end of the last interval in the result container to the maximum of its current end and the end of the current interval.

# Solution 

```csharp
public int[][] Merge(int[][] intervals) {
    if (intervals.Length <= 1)
        return intervals;

    List<int[]> result = new List<int[]>();

    // Sort by start time
    Array.Sort(intervals, (a, b) => a[0] - b[0]);

    int[] currentInterval = intervals[0];
    result.Add(currentInterval);

    foreach (var interval in intervals) {
        int currentEnd = currentInterval[1];
        int nextBegin = interval[0];
        int nextEnd = interval[1];

        if (currentEnd >= nextBegin) { // Overlapping intervals, merge them
            currentInterval[1] = Math.Max(currentEnd, nextEnd);
        } else { // Disjoint intervals, move on to the next one
            currentInterval = interval;
            result.Add(currentInterval);
        }
    }

    return result.ToArray();
}

```