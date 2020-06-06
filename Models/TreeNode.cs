namespace LeetCode
{
    public class TreeNode{
        public int Val{get;set;}
        public TreeNode Left{get;set;}
        public TreeNode Right{get;set;}

        public TreeNode(int v){
            Val = v;
            Left = null;
            Right = null;
        }
    }
}