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
    public class SimpleLinkedListGenerics<AnyType>
    {
        //this is the start node of the linked list chain
        Node<AnyType> head = null;

        //added this to improve the performance
        Node<AnyType> tail = null;
        
        //Add after tail
        //O(1)
        public void AddLast(AnyType data)
        {
            Node<AnyType> newItem = new Node<AnyType>();
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
        public void AddFirst(AnyType data)
        {
            Node<AnyType> newItem = new Node<AnyType>();
            newItem.data = data;
            
            if(head == null)
            {
                head = newItem;
                tail.next = newItem;
                tail.previous = null;
            }
            else
            {
                newItem.next = head;
                head = newItem;
            }
        }

        public void AddInBetween(AnyType data, int StartNode)
        {
            Node<AnyType> newItem = new Node<AnyType>();
            newItem.data = data;
            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }

            else
            {
                Node<AnyType> current = head;
                int currentNodePosition = 1;
                while (currentNodePosition < StartNode && current != null)
                {
                    current = current.next;
                    currentNodePosition++;
                }
                if(currentNodePosition == StartNode)
                {
                    if(current.next != null)
                    {
                        newItem.next = current.next;
                    }
                    current.next = newItem;
                   
                    if(current == tail)
                    {
                        tail = newItem;
                    }
                }
                else
                {
                    tail.next = newItem;
                    tail = newItem;
                }


            }
        }


        public void ReadAll()
        {
            Node<AnyType> currentNode = head;
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
