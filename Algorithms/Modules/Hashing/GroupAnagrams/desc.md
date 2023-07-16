# Task 

Given an array of strings strs, group the anagrams together. You can return the answer in any order.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

## Examples 

### Example 1:

```
Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
```

### Example 2:

```
Input: strs = [""]
Output: [[""]]
```

### Example 3:

```
Input: strs = ["a"]
Output: [["a"]]
```

# Algorithm 

1. Create an empty dictionary. Each key will be a sorted tuple of the characters in a word, and the value will be a list of words (anagrams) that, when sorted, give the key.
2. Iterate over each string in the input list. For each string:
    2.1. Convert the string to a list of characters, sort the list, and convert it back to a string. This is to ensure that anagrams, when sorted, give the same string.
    2.2.Check if the sorted string is in the dictionary. If it is not, add it with the value as a new list containing the current string.
    2.3. If it is, append the current string to the list of values.
3. The values of the dictionary will be groups of anagrams.
