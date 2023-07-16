# Task 

Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
You must write an algorithm that runs in O(n) time and without using the division operation.

## Examples 

### Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]

### Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]

# Algorithm 

1. Create a dictionary (hashmap) to store the numbers as keys and their corresponding indices as values.
2. Iterate through the input array of numbers.
3. For each number, calculate the complement by subtracting it from the target.
4. Check if the complement exists in the dictionary.
    - If it does, return the indices of the current number and the complement.
    - If it doesn't, add the current number and its index to the dictionary.
5. If no solution is found after iterating through the entire array, throw an exception or return an appropriate error message.
