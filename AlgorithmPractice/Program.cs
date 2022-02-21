using System;
using System.Collections.Generic;

namespace AlgorithmPractice
{
    class Program
    {
        public class TreeNode
        {
            public int Value;
            public List<TreeNode> Children;
        }

        static void Main(string[] args)
        {
            var numArray = new int[3] { 5, 2, 3 };
            Array.Sort(numArray);
            Console.WriteLine(numArray);
        }

        static TreeNode DepthFirstSearch(int value, TreeNode node)
        {
            // base case
            if (node.Value == value) return node;

            // recursive case
            TreeNode nodeFound = null;
            foreach (var child in node.Children)
            {
                nodeFound = DepthFirstSearch(value, child);
                if (nodeFound != null) break;
            }

            return nodeFound;
        }

        static TreeNode BreadFirstSearch(int value, Queue<TreeNode> queue)
        {
            // base case
            if (queue.Count == 0) return null;

            // get the node from the queue
            var node = queue.Dequeue();

            // base case
            if (node.Value == value) return node;

            // adding children to the queue
            foreach (var child in node.Children)
            {
                queue.Enqueue(child);
            }

            // recursive case
            return BreadFirstSearch(value, queue);
        }

    }
}
