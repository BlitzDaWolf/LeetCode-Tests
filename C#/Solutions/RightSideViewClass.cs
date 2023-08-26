class RightSideViewClass
{
    public IList<int> RightSideView(TreeNode root)
    {
        List<int> result = new List<int>();
        while (root != null)
        {
            result.Add(root.val);
            root = root.right;
        }
        return result;
    }
}