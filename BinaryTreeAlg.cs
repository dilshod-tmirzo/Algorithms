using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsGeeksForGeeks
{
    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public Node(int data)
        {
            Data = data;
            Left = null; Right = null;
        }

    }
    public class Tree
    {
        public Node Root;

        public Tree()
        {
            Root = null;
        }

        public void Insert(int data)
        {
            Node newNode = new Node(data);

            if (Root==null)
            {
                Root = newNode;
            }
            else
            {
                Node current = Root;
                Node parent;
                while (true)
                {
                    parent=current;
                    if (data<current.Data)
                    {
                        current = current.Left;
                        if (current==null)
                        {
                            parent.Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        if (data>current.Data)
                        {
                            current = current.Right;
                            if (current==null)
                            {
                                parent.Right = newNode;
                                return;
                            }
                        }
                    }
                }
            }


            //newNode.val = item;

            //if (root == null)
            //{
            //    root = newNode;
            //}
            //else
            //{
            //    Node current = root;
            //    Node parent;
            //    while (true)
            //    {
            //        if (item<current.val)
            //        {
            //            current = current.leftChild;
            //            if (current==null)
            //            {

            //            }
            //        }
            //    }

            //}
        }

        public bool SearchElement(int data)
        {
            Node current = Root;
            while (current!=null)
            {
                if (data==current.Data)
                {
                    Console.WriteLine("Element found");
                    return true;
                }
                else if(data<current.Data)
                {
                    current=current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            Console.WriteLine("Element not found");
            return false;
        }

        public void InorderTraversal(Node node)
        {
            if (node!=null)
            {
                InorderTraversal(node.Left);
                Console.WriteLine(node.Data + " ");
                InorderTraversal(node.Right);
            }
        }

        public void PreOrderTraversal(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Data + " ");
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }

        public void PostOrderTraversal(Node node)
        {
            if(node != null)
            {
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
                Console.WriteLine(node.Data + " ");
            }
        }

        public void InorderSuccessor(int data)
        {
            Node current = Root;
            while (current != null)
            {
                if (data == current.Data)
                {
                    int inordSuccess = current.Right.Data;
                    Console.WriteLine("Inorder Successor of "+data+" is: "+inordSuccess);
                    return ;
                }
                else if (data < current.Data)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            Console.WriteLine("The element doesn't have inorder sucessor");
            return ;
        }

        public void PostOrderSuccessor(int data)
        {
            Node current = Root;
            while (current != null)
            {
                if (data == current.Data)
                {
                    int postSuccess = current.Left.Data;
                    Console.WriteLine("Post Order Successor of " + data + " is: " + postSuccess);
                    return;
                }
                else if (data < current.Data)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            Console.WriteLine("The element doesn't have Post Order sucessor");
            return;
        }

    }
}
