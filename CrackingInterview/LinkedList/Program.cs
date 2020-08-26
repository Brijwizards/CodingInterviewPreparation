using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList
            ListNode listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);
            //listNode.next.next = new ListNode(3);
            //ListNode listNode2 = new ListNode(5);
            //listNode2.next = new ListNode(6);
            //listNode2.next.next = new ListNode(4);
            ////LinkedList.SortList(listNode);
            //LinkedList.PrintLinkedList(listNode);
            //LinkedList.AddTwoNumbers(listNode, listNode2);
            //LinkedList.IsPalindrome(listNode);
            LinkedList.RemoveNthFromEnd(listNode, 2);
            #endregion
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }
    class LinkedList
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyHead;
            int carry = 0;
            while (p != null || q != null)
            {
                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dummyHead.next;
        }

        public static ListNode BuildLinkedList()
        {
            ListNode linkedList = new ListNode(0);
            ListNode head = null;
            if (head == null)
            {
                head = linkedList;
                head.next = null;
            }
            return head;
        }

        public static ListNode SortList(ListNode head)
        {
            List<int> list = new List<int>();
            if (head == null)
            {
                return head;
            }
            ListNode current = head;
            while (current != null)
            {
                list.Add(current.val);
                current = current.next;
            }
            list.Sort();
            ListNode dummyNode = new ListNode(0);
            current = dummyNode;
            foreach (var item in list)
            {
                current.next = new ListNode(item);
                current = current.next;
            }
            return dummyNode.next;
        }

        public static void PrintLinkedList(ListNode head)
        {
            if (head == null)
            {
                return;
            }
            while (head != null)
            {
                Console.WriteLine(head.val);
                head = head.next;
            }
        }

        public static bool IsPalindrome(ListNode head)
        {
            if (head == null)
                return true;
            ListNode givenList = head;
            ListNode prev = null;
            ListNode current = head;
            ListNode temp = null;
            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            head = prev;

            if (givenList == head)
                return true;

            return false;
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            // count length
            int len = 0;
            ListNode node = head;
            while (node != null)
            {
                node = node.next;
                len++;
            }

            // move pointer to node before node to be removed
            int count = 0;
            ListNode tempHead = new ListNode(0);
            tempHead.next = head;
            node = tempHead;
            while (count < len - n)
            {
                node = node.next;
                count++;
            }

            // remove the next node
            node.next = node.next != null ? node.next.next : null;

            return tempHead.next;

        }

    }
}
