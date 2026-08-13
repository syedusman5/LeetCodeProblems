using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Easy
{
    internal class MergeTwoSortedLists
    {
        /*
        You are given the heads of two sorted linked lists list1 and list2.

        Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

        Return the head of the merged linked list.

        Example 1:

        Input: list1 = [1,2,4], list2 = [1,3,4]
        Output: [1,1,2,3,4,4]
        Example 2:

        Input: list1 = [], list2 = []
        Output: []
        Example 3:

        Input: list1 = [], list2 = [0]
        Output: [0]
 

        Constraints:

        The number of nodes in both lists is in the range [0, 50].
        -100 <= Node.val <= 100
        Both list1 and list2 are sorted in non-decreasing order. 
         */

        //TestCase 1 : [1,2,4], [1,3,4]
        //TestCase 1 : [], []
        //TestCase 1 : [], [0]

        

        public static ListNode Solution(ListNode list1, ListNode list2)
        {
            ListNode result = new ListNode();
            ListNode curr = result;

            if (list1 == null && list2 != null) return list2;
            if (list2 == null && list1 != null) return list1;
            if (list1 == null && list2 == null) return null;

            while(list1 != null && list2 != null)
            {
                if(list1.val < list2.val)
                {
                    curr.next = list1;

                    list1 = list1.next;

                }
                else
                {
                    curr.next = list2;

                    list2 = list2.next;
                }
                curr = curr.next;
            }

            if(list1 == null)
            {
                if(list2.next == null)
                {
                    curr.next = list2;
                }
                else
                {
                    curr.next = list2;
                }
                
            }
            else
            {
                if (list1.next == null)
                {
                    curr.next = list1;
                }
                else
                {
                    curr.next = list1.next;
                }
            }

            return result.next;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
