// TRICKY
bool IsAnagram(string s, string t)
{
    // when len is not equal than exit
    if (s.Length != t.Length)
        return false;

    int[] charCount = new int[26]; // Assuming only lowercase English letters

    // Count the frequency of characters in string s
    foreach (char c in s)
        charCount[c - 'a']++;

    // Subtract the frequency of characters in string t
    // If all counts become zero, t is an anagram of s
    foreach (char c in t)
    {
        charCount[c - 'a']--;
        if (charCount[c - 'a'] < 0)
            return false;
    }

    return true;
}

// HASHMAP 
bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
        return false;

    Dictionary<char, int> charCount = new Dictionary<char, int>();

    // Count the frequency of characters in string s
    foreach (char c in s)
    {
        if (charCount.ContainsKey(c))
            charCount[c]++;
        else
            charCount[c] = 1;
    }

    // Subtract the frequency of characters in string t
    foreach (char c in t)
    {
        if (!charCount.ContainsKey(c) || charCount[c] == 0)
            return false;

        charCount[c]--;
    }

    return true;
}
