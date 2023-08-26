class HasPathSumClass
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if(root == null) return false;
        if (targetSum - root.val == 0) return true;
        if (targetSum - root.val < 0) return false;

        if (HasPathSum(root.left, targetSum - root.val)) return true;
        if (HasPathSum(root.right, targetSum - root.val)) return true;

        return false;
    }
}