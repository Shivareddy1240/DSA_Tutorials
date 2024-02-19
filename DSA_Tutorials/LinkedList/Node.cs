using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Tutorials.LinkedList
{
    //This class represents a node in linkedlist
    public class Node
    {
       public  object data = null;
       public  Node next = null;
    }

    public class Node<AnyType>
    {
        public AnyType data;
        public Node<AnyType> next;

        //For Double Linked List
        public Node<AnyType> previous;
    }
}
