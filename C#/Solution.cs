using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public ListNode Partition(ListNode head, int x)
        {
            if (head == null) return null;
            List<ListNode> nodes = new List<ListNode>();
            {
                ListNode current = head;
                while (current != null)
                {
                    nodes.Add(current);
                    current = current.next;
                }
            }
            nodes.ForEach(x => x.next = null);
            List<ListNode> final = nodes
                .Where(y => y.val < x)
                .Concat(nodes.Where(y => y.val >= x)).ToList();
            for (int i = 0; i < final.Count - 1; i++)
            {
                final[i].next = final[i + 1];
            }
            return final[0];
        }

        public int RemoveDuplicates(int[] nums)
        {
            nums = nums.Distinct().ToArray();
            return nums.Length;
        }

        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums.Length == 0 || k == 0) return new int[0];
            int[] result = new int[nums.Length - k + 1];

            int ri = 0;
            LinkedList<int> q = new LinkedList<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                while (q.Count > 0 && q.First.Value < i - k + 1) q.RemoveFirst();
                while (q.Count > 0 && nums[q.Last.Value] <= nums[i]) q.RemoveLast();

                q.AddLast(i);
                if (i >= k - 1) result[ri++] = nums[q.First.Value];
            }

            return result;
        }

        public bool RepeatedSubstringPattern(string s)
        {
            Enumerable.Range(0, s.Length / 2).Select(x => x % 2 == 0 ? s.Substring(0, x)=="" : false);
            if (s.Length % 2 == 1) return false;
            var sub_str = s.Substring(0, s.Length / 2);
            s = s.Remove(0, s.Length / 2);
            var res = (s.Contains(sub_str));
            return res;
        }

        public int MinTimeToVisitAllPoints(int[][] points)
        {
            List<int[]> Path = new List<int[]>();
            int[] target = points[1];
            int[] current = points[0];
            Path.Add(current);

            for (int i = 0; i < points.Length - 1; i++)
            {
                target = points[i+1];
                current = points[i];
                Console.WriteLine(string.Join(",", current));

                int[] offset = new int[] { target[0] - current[0], target[1] - current[1] };
                while (offset.Sum() != 0)
                {
                    current[0] += Math.Max(-1, Math.Min(1, offset[0]));
                    current[1] += Math.Max(-1, Math.Min(1, offset[1]));

                    Path.Add(new int[] { current[0], current[1] });
                    Console.WriteLine(string.Join(",", current));
                    offset = new int[] { target[0] - current[0], target[1] - current[1] };
                }
            }

            Console.WriteLine(string.Join(",",
                Path.Select(x => "[" +string.Join(",", x) + "]")));

            return Path.Count - 1;
        }

        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0) return null;
            List<ListNode> nodes = new List<ListNode>();
            {
                for (int i = 0; i < lists.Length; i++)
                {
                    ListNode current = lists[i];
                    while (current != null)
                    {
                        nodes.Add(current);
                        current = current.next;
                    }
                }
            }

            nodes= nodes.OrderBy(x => x.val).ToList();

            nodes.ForEach(x => x.next = null);
            List<ListNode> final = nodes.ToList();
            if (final.Count > 1)
            {
                for (int i = 0; i < final.Count - 1; i++)
                {
                    final[i].next = final[i + 1];
                }
            }
            Console.WriteLine(string.Join(",", nodes.Select(x => x.val)));
            if (final.Count == 0) return null;
            return final[0];
        }

        public int Search(int[] nums, int target)
        {
            if (!nums.Contains(target)) return -1;
            return nums.ToList().IndexOf(target);
        }

        public bool IsValid(string s)
        {
            List<char> open = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                    case '[':
                    case '{':
                        open.Add(s[i]);
                        break;
                    case ')':
                        open.Remove('(');
                        break;
                    case '}':
                        open.Remove('{');
                        break;
                    case ']':
                        open.Remove('[');
                        break;
                }
            }
            return open.Count == 0;
        }

        public int LengthOfLastWord(string s)
        {
            return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Last().Length;
        }
        public string[] UncommonFromSentences(string s1, string s2)
        {
            string[] total = (s1 + " " + s2).Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return total.Where(x => total.Where(y => y == x).Count() == 1).ToArray();
        }

        public int GetDecimalValue(ListNode head)
        {
            if (head == null) return 0;
            ListNode current = head;
            int move = -1;
            while (current != null) { move++; current = current.next; }
            int result = 0;
            current = head;

            while (current != null)
            {
                result += current.val << move;
                current = current.next;
                move--;
            }

            return result;
        }

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

        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if(root == null) return false;
            if (targetSum - root.val == 0) return true;
            if (targetSum - root.val < 0) return false;

            if (HasPathSum(root.left, targetSum - root.val)) return true;
            if (HasPathSum(root.right, targetSum - root.val)) return true;

            return false;
        }

        public int LengthOfLongestSubstring(string s)
        {
            int best = 0;
            for (int i = 0; i < s.Length; i++)
            {
                string current = "";
                for (int j = i; j < s.Length; j++)
                {
                    if (current.Contains(s[j])) break;
                    current += s[j];
                }
                best = Math.Max(best, current.Length);
            }
            return best;
        }

        public string LongestCommonPrefix(string[] strs)
        {
            var smalestWord = strs.OrderBy(x => x.Length).First();
            string best = "";

            for (int i = 1; i < smalestWord.Length; i++)
            {
                var sub = smalestWord.Substring(0, i+1);
                if (strs.Select(x => x.StartsWith(sub)).Contains(false)) break;
                best = sub;
            }

            return best;
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            List<int> v1 = new List<int>();
            { while (l1 != null) { v1.Add(l1.val); l1 = l1.next; } }
            List<int> v2 = new List<int>();
            { while (l2 != null) { v2.Add(l2.val); l2 = l2.next; } }

            if(v2.Count > v1.Count)
            {
                var tmp = v1;
                v1 = v2;
                v2 = tmp;
            }

            for (int i = 0; i < Math.Min(v1.Count, v2.Count); i++)
            {
                v1[i] += v2[i];
            }

            for (int i = 0; i < v1.Count-1; i++)
            {
                int tmp = v1[i];
                v1[i] = tmp % 10;
                v1[i + 1] += tmp / 10;
            }
            if(v1.Last() >= 10)
            {
                int tmp = v1[v1.Count -1];
                v1[v1.Count - 1] = tmp % 10;
                v1.Add(tmp / 10);
            }

            List<ListNode> nodes = new List<ListNode>() { new ListNode(v1[0])};
            for (int i = 1; i < v1.Count; i++)
            {
                ListNode node = new ListNode(v1[i]);
                nodes.Last().next = node;
                nodes.Add(node);
            }

            return nodes[0];
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if(head == null) return null;
            if (head.next == null) return null;
            int c = -1;
            { ListNode cu = head; while(cu != null) { c++; cu = cu.next; } }

            {
                ListNode cu = head;

                for (int i = 0; i < c-n; i++)
                {
                    cu= cu.next;
                }

                if(c-n < 0)
                {
                    head = head.next;
                }

                cu.next = cu.next.next;
            }

            return head;
        }

        public string ReorganizeString(string s)
        {
            var grouped = s.GroupBy(c => c)
                .OrderByDescending(c => c.Count());
            if (grouped.First().Count() > (s.Length + 1) / 2) return "";

            var res = new char[s.Length];
            int idx = 0;

            foreach (var c in grouped.SelectMany(c => c))
            {
                res[idx] = c;
                idx += 2;
                if (idx >= s.Length)
                    idx = 1;
            }

            return new string(res);
        }

        int minimumDeleteSum(string s1, string s2)
        {
            return (s1 + s2).Distinct().Select(x => (int)x).Sum();
        }

        public int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target) return new int[] { numbers[i], numbers[j] };
                }
            }
            return null;
        }

        public int[] ProductExceptSelf(int[] nums)
        {
            GC.Collect();
            int[] res = new int[nums.Length];
            for (int i = 0, prev = 1; i < nums.Length; i++)
            {
                res[i] = prev;
                prev = nums[i] * prev;
            }

            for (int i = nums.Length - 1, prev = 1; i >= 0; i--)
            {
                res[i] = res[i] * prev;
                prev = nums[i] * prev;
            }

            return res;
        }

        public bool Exist(char[][] board, string word)
        {
            var r = string.Concat(board.SelectMany(x => x));

            int i = 0;
            while (i < r.Length)
            {
                if (word.Contains(r[i]))
                {
                    word = word.Remove(word.IndexOf(r[i]), 1);
                    r = r.Remove(i,1);
                }
                else
                    i++;
            }

            return string.IsNullOrEmpty(word);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string KthLargestNumber(string[] nums, int k)
        {
            int index = nums.Length - k;
            Console.WriteLine("Index: " + index);
            var v = nums.Select(y => (y, y.Select((x, i) => ((int)x) * (i ^ 10 + 1)).Sum()))
                .OrderBy(x => x.Item2)
                // .Select(x => x.Item2)
                .ToList();
            Console.WriteLine("Sorted: " + string.Join(", ", v.Select(x => x.y + ":" + x.Item2)));
            return "";
        }

        string check (int num)
        {
            if (num % 3 == 0 && num % 5 == 0) return "FizzBuzz";
            if (num % 3 == 0) return "Fizz";
            if (num % 5 == 0) return "Buzz";
            return num.ToString();
        }
        public IList<string> FizzBuzz(int n)
        {
            return Enumerable.Range(1,n+1).Select(check).ToList();
        }

        public string ReverseWords(string s)
        {
            return string.Join(' ', s.Split(' ').Select(x => string.Concat(x.Reverse())));
        }

        public bool WordPattern(string pattern, string s)
        {
            var v = s.Split(' ');
            if(v.Length != pattern.Length) return false;
            Dictionary<char, string> d = new Dictionary<char, string>();
            for (int i = 0; i < v.Length; i++)
            {
                if (!d.ContainsKey(pattern[i]))
                {
                    if (d.ContainsValue(v[i])) return false;
                    d.Add(pattern[i], v[i]);
                }
                else
                {
                    if (v[i] != d[pattern[i]]) return false;
                }
            }
            return true;
        }

        public string ToHex(int num)
        {
            return num.ToString("X").ToLower();
        }

        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            List<string> justifiedLines = new List<string>();
            string currentLine = "";

            foreach (string word in words)
            {
                if ((currentLine + word).Length <= maxWidth)
                {
                    currentLine += word + " ";
                }
                else
                {
                    justifiedLines.Add(JustifyLine(currentLine.Trim(), maxWidth));
                    currentLine = word + " ";
                }
            }

            // Justify the last line
            justifiedLines.Add(JustifyLine(currentLine.Trim(), maxWidth));

            return justifiedLines;
        }

        string JustifyLine(string line, int lineLength)
        {
            string[] words = line.Split(' ');
            int spaceCount = Math.Max(words.Length - 1,1);
            int totalSpacesNeeded = Math.Max(words.Length - 1, 1);

            int baseSpaces = totalSpacesNeeded / spaceCount;
            int extraSpaces = totalSpacesNeeded % spaceCount;

            string justifiedLine = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                int spacesToAdd = baseSpaces + (i <= extraSpaces ? 1 : 0);
                justifiedLine += new string(' ', spacesToAdd) + words[i];
            }

            return justifiedLine;
        }

        public bool DivideArray(int[] nums)
        {
            if(nums.Length %2!=0) return false;
            List<int> data = nums.ToList();
            while (data.Count > 0)
            {
                var c = data.First();
                data.RemoveAt(0);
                int inx = data.IndexOf(c);
                if (inx == -1) return false;
                data.RemoveAt(inx);
            }
            return true;
        }

        public string[] FindOcurrences(string text, string first, string second)
        {
            var v = text.Split(" ");
            List<string> result = new List<string>();
            int j = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if(j == 2)
                {
                    result.Add(v[i]);
                    j = 0;
                }
                if (j == 1)
                {
                    j = v[i] == second ? 2 : 0;
                }
                if (j == 0)
                {
                    j = v[i] == first ? 1 : 0;
                }
            }
            return result.ToArray();
        }

        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}
