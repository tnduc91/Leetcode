using System;
using LeetCode.Models;

namespace LeetCode
{
    public class MinimumDistanceBST
    {
        public int MinDiffInBST(TreeNode root)
        {
            var min = Int32.MaxValue;
            MinDiffInBST(root, ref min);
            return min;
        }

        public static void MinDiffInBST(TreeNode root, ref int min)
        {
            if (root == null)
                return;

            if (root.Left != null)
            {
                var diff = Math.Abs(root.Val - Max(root.Left));
                min = min > diff ? diff : min;
            }
            if (root.Right != null)
            {
                var diff = Math.Abs(root.Val - Min(root.Right));
                min = min > diff ? diff : min;
            }
            MinDiffInBST(root.Left, ref min);
            MinDiffInBST(root.Right, ref min);
        }

        public static int Max(TreeNode root)
        {
            var tmp = root;
            while (tmp.Right != null)
                tmp = tmp.Right;

            return tmp.Val;
        }

        public static int Min(TreeNode root)
        {
            var tmp = root;
            while (tmp.Left != null)
                tmp = tmp.Left;

            return tmp.Val;
        }
    }
}