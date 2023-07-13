# Task 

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.

# Algorithm 

1. Create a dictionary (hashmap) to store the numbers as keys and their corresponding indices as values.
2. Iterate through the input array of numbers.
3. For each number, calculate the complement by subtracting it from the target.
4. Check if the complement exists in the dictionary.
    - If it does, return the indices of the current number and the complement.
    - If it doesn't, add the current number and its index to the dictionary.
5. If no solution is found after iterating through the entire array, throw an exception or return an appropriate error message.
