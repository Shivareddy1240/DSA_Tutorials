using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Tutorials.LinkedList
{
    //this class will have the logic
    //to connect the node objects to create
    //link list structure
    public class SimpleLinkedList
    {
        //this is the start node of the linked list chain
        Node head = null;
        //Add after tail

        //O(n)
        public void AddLast(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            if (head == null)
            {
                head = newItem;
                head.next = null;
            }
            else
            {
                Node currentNode = head;
                //loop and find last node and add after it
                while(currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                // in while loop if we gets null means that is the last node
                currentNode.next = newItem;
                newItem.next = null;
            }
        }
        //Add before Head
        public void AddFirst(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            //now this is  the first item
            //so the current head become next item to new item
            newItem.next = head;
            //new item becomes the head
            head = newItem;
        }

        public void ReadAll()
        {
            Node currentNode = head;
            //loop until the last node
            //display data
            while (currentNode.next != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
            Console.WriteLine(currentNode.data);
        }

    }
}
