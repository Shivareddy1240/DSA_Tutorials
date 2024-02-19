using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Tutorials.LinkedList
{
    //this class will have the logic
    //to connect the node objects to create
    //link list structure
    public class SimpleLinkedListTail
    {
        //this is the start node of the linked list chain
        Node head = null;

        //added this to improve the performance
        Node tail = null;
        
        //Add after tail
        //O(1)
        public void AddLast(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            //step1 - first item
            // head -> new item
            //tail ->new item
            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                //step2 - second item
                //current tails next item set to new item
                //current tail set to new item
                tail.next = newItem;
                tail = newItem;
            }
        }
        //Add before Head
        public void AddFirst(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            
            if(head == null)
            {
                head = newItem;
                tail.next = newItem;
            }
            else
            {
                newItem.next = head;
                head = newItem;
            }
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
