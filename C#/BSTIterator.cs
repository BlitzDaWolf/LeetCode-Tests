using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BSTIterator
    {
        Queue<int> result = new Queue<int>();
        public BSTIterator(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                var v = q.Dequeue();
                if (v == null) continue;
                q.Enqueue(v.left); q.Enqueue(v.right);
            }
        }

        public int Next()
        {
            return result.Dequeue();
        }

        public bool HasNext()
        {
            return result.Count > 0;
        }
    }
}
