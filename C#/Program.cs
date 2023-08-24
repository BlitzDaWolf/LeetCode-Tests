using ConsoleApp1;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

ListNode createList(int[] data)
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


Solution sln = new Solution();
sln.FindOcurrences("alice is a good girl she is a good student", "a", "good");
sln.FindOcurrences("we will we will rock you", "we", "will");
