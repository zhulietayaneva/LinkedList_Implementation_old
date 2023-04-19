using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
    internal class LinkedList
    {
        public Node? First { get; private set; }
        public Node? Last { get; private set; }

        public void AddFirst(int value)
        {
            if (Last == null)
            {
                First = new Node(value, null);
                Last = First;
            }
            else
            {
                First = new Node(value, First);
            }
        }
        public void AddLast(int value)
        {
            if (Last != null)
            {
                Node curr = First;
                while (curr.Next!=null)
                {
                    curr = curr.Next;
                }
                Last = curr;
                Last.Next = new Node(value, null);
            }
            else
            {
                AddFirst(value);
            }
        }
        public void DeleteFirst()
        {
            if (First != null)
            {
                First = First.Next;
            }
        }
        public void DeleteLast()
        {
            if (Last != null && First != null)
            {
                Node curr = First;
                while (curr.Next != Last)
                {
                    curr = curr.Next;
                }
                curr=curr.Next;
                Last = curr;
                curr.Next = null;
            }
        }
        public bool Contains(int value)
        {
            if (First != null)
            {
                Node curr = First;
                while (curr.Next != null)
                {
                    if (curr.Value == value)
                    {
                        return true;
                    }
                    else
                    {
                        curr = curr.Next;
                    }
                }
            }
            return false;
        }
        public int IndexOf(int value)
        {
            if (First != null)
            {
                Node curr = First;
                int index = 0;
                while (curr.Next != null)
                {
                    if (curr.Value == value)
                    {
                        return index;
                    }
                    else
                    {
                        curr = curr.Next;
                        index++;
                    }
                }
            }
            return -1;
        }
        public int GetSize()
        {
            if (First != null)
            {
                Node curr = First;
                int count = 1;
                while (curr.Next != null)
                {
                    curr = curr.Next;
                    count++;
                }
                return count;
            }
            return 0;
        }
        public int[] ToArray()
        {
            var list = ToList();
            if (list.Count!=0)
            {
                return list.ToArray();
            }
           
            return Array.Empty<int>();
        }
        public List<int> ToList()
        {
            if (First != null)
            {
                List<int> list = new List<int>();
                Node curr = First;
                while (curr.Next != null)
                {
                    list.Add(curr.Value);
                    curr = curr.Next;
                }
                list.Add(curr.Value);
                return list;
            }
            return new List<int>();
        }
        public override string ToString()
        {
            if (First!=null)
            {
                return $"[{String.Join(',', this.ToList())}]";
            }

            return "Empty list";
        }
    }
}
