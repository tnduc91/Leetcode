using System;
using System.Collections.Generic;
using LeetCode.Models;

namespace LeetCode
{
    class Program
    {
         public static void Main(string[] args)
        {
            var l1 = new ListNode(1, null);
            var l2 = new ListNode(9, new ListNode(9, null));
            var res = AddTwoNumbers(l1, l2);
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

        
        var moveForward = 0;
        ListNode res = null;
        ListNode tail = null;
        
        while (l1 != null || l2 != null){
            var v1 = 0;
            var v2 = 0;
            
            if (l1 != null){
                v1 = l1.val;
                l1 = l1.next;
            }
            if (l2 != null){
                v2 = l2.val;
                l2 = l2.next;
            }
            var sum = v1 + v2 + moveForward;
            
            
            if (sum < 10){
                moveForward = 0;
            }else{
                sum = sum - 10;
                moveForward = 1;
            }
            var newNode = new ListNode(sum);
            
            if (res == null){
                res = newNode;
                tail = newNode;
            }else{
                tail.next = newNode;
                tail = tail.next;
            }
            
        }
        
        if (moveForward > 0){
            tail.next = new ListNode(1);
        }
        
        return res;
        }
    }
    
}
