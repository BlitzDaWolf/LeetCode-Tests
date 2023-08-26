using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode createList(int[] data)
        {
            var list = new List<ListNode>();
            foreach (var item in data)
            {
                list.Add(new ListNode(item));
            }

            if (list.Count > 1)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    list[i].next = list[i + 1];
                }
            }
            if (list.Count == 0)
                return null;
            return list[0];
        }
    }
}