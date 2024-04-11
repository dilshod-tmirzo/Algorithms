using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsGeeksForGeeks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //DSMethods objAnagram = new DSMethods();
            //objAnagram.IsAnagram("anagram","maranag");

            //DSMethods algMethod = new DSMethods();
            //isDuplicate.CheckIntArrayDupl();

            //globalIntType.SumOfTwoNums();

            //globalIntType.LongestCOnsecutiveNumbers();

            //algMethod.LongestSubstring();
            //algMethod.LongestPalindromicSubstring();
            //algMethod.ReverseInteger();
            //Console.WriteLine((int)"-".ToCharArray()[0]);
            //algMethod.TwoSum();

            //algMethod.LargestPrimeFactor();
            #endregion

            Tree tree = new Tree();
            tree.Insert(15);
            tree.Insert(9);
            tree.Insert(17);
            tree.Insert(7);
            tree.Insert(25);
            tree.Insert(16);

            //tree.SearchElement(12);

            //tree.InorderTraversal(tree.Root);

            //tree.PreOrderTraversal(tree.Root);

            //tree.PostOrderTraversal(tree.Root);

            //tree.InorderSuccessor(17);

            //tree.PostOrderSuccessor(17);

            //Graph graphMethods = new Graph();
            //graphMethods.DepthFirst();

            //BreadthFirstSearch bfsMethods = new BreadthFirstSearch();
            //bfsMethods.BreadthFirst();
            Console.ReadLine();

        }

        
    }
}
