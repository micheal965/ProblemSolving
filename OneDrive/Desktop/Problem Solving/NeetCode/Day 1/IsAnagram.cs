namespace Problem_Solving.NeetCode.Day_1
{
    class IsAnagram
    {
        ///Solution 1
        //public static bool IsAnagram(string s, string t)
        //{
        //    if (s.Length != t.Length) return false;
        //    var str1 = AddItemToDic(s);
        //    var str2 = AddItemToDic(t);

        //    foreach (var item in str2)
        //    {
        //        if (!str1.ContainsKey(item.Key))
        //            return false;
        //        else if (item.Value != str1[item.Key])
        //            return false;
        //    }

        //    return true;
        //}
        //public static Dictionary<char, int> AddItemToDic(string s)
        //{
        //    var str = new Dictionary<char, int>();
        //    foreach (var item in s)
        //    {
        //        if (str.ContainsKey(item))
        //            str[item] += 1;
        //        else
        //            str.Add(item, 1);
        //    }
        //    return str;
        //}




        ///Solution 2
        //public static bool IsAnagram(string s, string t)
        //{
        //    if (s.Length != t.Length) return false;
        //    char[] sSort = s.ToCharArray();
        //    char[] tSort = t.ToCharArray();

        //    Array.Sort(sSort);
        //    Array.Sort(tSort);

        //    return sSort.SequenceEqual(tSort);
        //}
    }
}
