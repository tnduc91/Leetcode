using System;
using LeetCode.Models;

namespace LeetCode
{
    public class RotateList
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null) return null;
            if (head.next == null || k == 0) return head;

            var tail = head;
            var len = 1;
            while(tail.next != null){
                len ++;
                tail = tail.next;
            }
            tail.next = head;

            var headMoveToNewHead = len - (k % len);
            while(headMoveToNewHead > 1){
                head = head.next;
                headMoveToNewHead --;
            }

            var newHead = head.next;
            head.next = null;

            return newHead;

        }


    }
}