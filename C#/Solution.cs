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
    }
}
