// no need to put all values to HashMap (when true)
bool ContainsDuplicate(int[] nums)
{
    HashSet<int> set = new HashSet<int>();

    foreach (int num in nums)
    {
        if (set.Contains(num))
            return true;

        set.Add(num);
    }

    return false;
}
