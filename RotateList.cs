using System;
using LeetCode.Models;

namespace LeetCode
{
    public class RotateList
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null) return null;
            if (head.Next == null || k == 0) return head;

            var tail = head;
            var len = 1;
            while(tail.Next != null){
                len ++;
                tail = tail.Next;
            }
            tail.Next = head;

            var headMoveToNewHead = len - (k % len);
            while(headMoveToNewHead > 1){
                head = head.Next;
                headMoveToNewHead --;
            }

            var newHead = head.Next;
            head.Next = null;

            return newHead;

        }


    }
}