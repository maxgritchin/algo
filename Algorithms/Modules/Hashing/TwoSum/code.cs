/* 
solution with Sorting and HashMap

Time Complexity: O(n m log m), where n is the length of the list, and m is the maximum length of a string in strs. This is because each string is sorted which takes O(m log m) time, and this is done for n strings.
Space Complexity: O(n m), for the dictionary to hold the strings.

*/
IList<IList<string>> GroupAnagrams(string[] strs) {
    var map = new Dictionary<string, List<string>>();

    foreach (string s in strs) 
    {
        var ca = s.ToCharArray();
        Array.Sort(ca);

        var key = new string(ca);

        if (!map.ContainsKey(key)) 
        {
            map[key] = new List<string>();
        }
        
        map[key].Add(s);
    }

    return new List<IList<string>>(map.Values);
}    

/* 
An alternate approach could involve creating a frequency count of characters for each string and using this count as a hash map key. 
This would avoid the need to sort the strings but would slightly complicate the hashing process and still have a similar time complexity of O(n m), where n is the number of strings and m is the maximum length of a string. 
Therefore, the original approach usually provides a good balance between code simplicity and efficiency.

As with the previous solution, this approach has a time complexity of O(n m) and a space complexity of O(n m).
*/

IList<IList<string>> GroupAnagrams(string[] strs) 
{
    var map = new Dictionary<string, List<string>>();
    
    foreach (string s in strs) 
    {
        // only small chars as numbers 
        int[] count = new int[26];
        foreach (char c in s)
        {
            count[c - 'a']++;
        }

        // create a hash for key 
        // based in the letters saved in prev step        
        var sb = new StringBuilder();
        for (int i = 0; i < 26; i++)
            sb.Append(count[i]);

        var key = sb.ToString();

        // add to hashmap
        if (!map.ContainsKey(key)) 
        {
            map[key] = new List<string>();
        }

        map[key].Add(s);
    }
    
    return new List<IList<string>>(map.Values);
}

