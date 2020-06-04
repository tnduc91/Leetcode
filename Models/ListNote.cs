namespace LeetCode.Models
{
    public class ListNode
    {
        public int val {get;set;}
        public ListNode next {get;set;}

        public ListNode(int v = 0, ListNode n = null)
        {
            this.val = v; 
            this.next = n;
        }
    }
}