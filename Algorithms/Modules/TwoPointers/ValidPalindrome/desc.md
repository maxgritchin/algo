# Task 

A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.
 
## Example 1:

```
Input: s = "A man, a plan, a canal: Panama"
Output: true
```
Explanation: "amanaplanacanalpanama" is a palindrome.

## Example 2:

```
Input: s = "race a car"
Output: false
```

Explanation: "raceacar" is not a palindrome.

## Example 3:

```
Input: s = " "
Output: true
```

Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.

# Solution 

This function uses two pointers to traverse the string from both ends. It moves the pointers past any non-alphanumeric characters and then compares the characters at the two pointers. If they are not equal, the function returns false. If the pointers meet or pass each other, then the function returns true, because we have checked all characters and found them to be palindromic.

This solution runs in `O(n)` time, where n is the length of the string, as we potentially need to check every character once. It uses ` O(1)` space as we do not allocate any additional memory proportional to the input size.
 