bool IsPalindrome(string s) {
    var start = 0;
    var end = s.Length - 1;
    
    while(start < end) {
        // skip until num or char at left 
        while(start < end && !Char.IsLetterOrDigit(s[start])) start++;
        // skip until num or char at right 
        while(start < end && !Char.IsLetterOrDigit(s[end])) end--;
        
        // compair 
        if(Char.ToLower(s[start]) != Char.ToLower(s[end])) return false;
        
        // next
        start++;
        end--;
    }

    return true;
}