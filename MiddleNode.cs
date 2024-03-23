using ProblemSolving.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class MiddleNode
    {
        public LinkedListNode MiddleNodeSolution(LinkedListNode head)
        {
            //[1,2,3,4,5,6]
            LinkedListNode result = new LinkedListNode();

            decimal size = 1;
            LinkedListNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
                size++;
            }

            if (size == 2)
            {
                return head.next;
            }

            decimal isMiddle = size / 2;
            if (size %2 == 0) {
                isMiddle++;
            }
            for (int i = 1; i <= size; i++)
            {
                if (i == int.Parse(Math.Ceiling(isMiddle).ToString()))
                {
                    result = head;
                    break;
                }
                else
                {
                    head = head.next;
                }
            }

            return result;
        }
    }
}
