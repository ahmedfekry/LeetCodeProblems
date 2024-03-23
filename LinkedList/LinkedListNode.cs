using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LinkedList
{
    public class LinkedListNode
    {
        public int val { get; set; }
        public LinkedListNode next;
        public LinkedListNode(int val=0,LinkedListNode next=null) { 
            this.val = val;
            this.next = next;
        }
    }
}
