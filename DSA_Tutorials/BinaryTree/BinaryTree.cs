using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Tutorials.BinaryTreeExamples
{
    public class BinaryTree
    {
        public Node root = null;

        public void Add(int value)
        {
            Node current = new Node();
            current.data = value;

            //root is null - add new item as root
            if(root == null)
            {
                root = current;
                return;
            }

            //if root is not null - start the recursion
            else
            {
                Add(root,value);
            } 
        }

        private void Add(Node _root,int value)
        {
            Node current = new Node();
            current.data = value;
            // root value is greater than the value -> goes to left
            if(_root.data > value)
            {
                //So checking left node
                //check if left node is null
                if(_root.leftNode == null)
                {
                    _root.leftNode = current;
                }
                //If left node is not null - means we already have an element there
                else
                {
                    //go ahead and make a recursive call
                    Add(_root.leftNode, value);
                }
            }

            //root value is less than value -> goes to right
            else
            {
                //So checking right node
                //check if right node is null
                if (_root.rightNode == null)
                {
                    _root.rightNode = current;
                }
                //If right node is not null - means we already have an element there
                else
                {
                    //go ahead and make a recursive call
                    Add(_root.rightNode, value);

                }
            }
        }

        public void Remove(int value)
        {
            Remove(root,value);
        }

        private Node Remove(Node root, int value)
        {
            //If the tree is empty, return null
            if (root == null)
                return root;

            // If the value to remove is less than the root value, search in the left subtree
            if (value < root.data)
                root.leftNode = Remove(root.leftNode, value);
            // If the value to remove is greater than the root value, search in the right subtree
            else if (value > root.data)
                root.rightNode = Remove(root.rightNode, value);
            else
            {
                // Node to remove is found

                // Node with only one child or no child
                if (root.leftNode == null)
                    return root.rightNode;
                else if (root.rightNode == null)
                    return root.leftNode;

                // Node with two children: Get the inorder successor (smallest in the right subtree)
                root.data = MinValue(root.rightNode);

                // Remove the inorder successor
                root.rightNode = Remove(root.rightNode, root.data);
            }
            return root;
        }

        // Helper function to find the minimum value in a BST
        private int MinValue(Node node)
        {
            int minv = node.data;
            while (node.leftNode != null)
            {
                minv = node.leftNode.data;
                node = node.leftNode;
            }
            return minv;
        }


        public Node Search(int value)
        {
           return Search(root, value);
        }

        private Node Search(Node root,int value)
        {
            if(root.data == value)
            {
                return root;
            }

           if(root.data > value)
            {
                return Search(root.leftNode,value);
            }
            else
            {
                return Search(root.rightNode, value); 
            }
        }

        public void DisplayTree()
        {
            this.DisplayTree(root);
        }

        private void DisplayTree(Node root)
        {
            if (root == null) return;
            DisplayTree(root.leftNode);
            Console.WriteLine(root.data + "");
            DisplayTree(root.rightNode);
        }

    }
}
