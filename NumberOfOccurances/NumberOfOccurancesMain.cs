// 1. Write a program that counts, in a given array of integers, the number of
// occurrences of each integer.
// Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
// 2  2 times 3  4 times 4  3 times

namespace NumberOfOccurances
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class NumberOfOccurancesMain
    {
        private static readonly Dictionary<int, int> Occurances = new Dictionary<int, int>();

        static void Main()
        {
            Tree<int> tree =
                new Tree<int>(1,
                    new Tree<int>(2,
                    new Tree<int>(1),
                    new Tree<int>(2),
                    new Tree<int>(3)),
                new Tree<int>(4),
                new Tree<int>(3,
                    new Tree<int>(2),
                    new Tree<int>(3))
                );

            TraverseTree(tree.Root);

            foreach (KeyValuePair<int, int> element in Occurances)
            {
                Console.WriteLine("{0} -> {1} times", element.Key, element.Value);
            }
        }

        private static void TraverseTree(TreeNode<int> root)
        {
            if (Occurances.Keys.Any(k => k == root.Value))
            {
                Occurances[root.Value] += 1;
            }
            else
            {
                Occurances.Add(root.Value, 1);
            }

            TreeNode<int> child = null;
            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                TraverseTree(child);
            }
        }
    }
}
