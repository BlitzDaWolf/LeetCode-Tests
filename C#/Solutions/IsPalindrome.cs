class IsPalindrome
{
    public bool IsPalindrome(ListNode head)
    {
        ListNode curr = head;
        string a = "";
        while (curr != null)
        {
            a += curr.val;
            curr = curr.next;
        }
        if (a.Length % 2 == 1) return false;
        var rev = string.Concat(a.Substring(0, a.Length/2).Reverse());
        return a.EndsWith(rev);
    }
}