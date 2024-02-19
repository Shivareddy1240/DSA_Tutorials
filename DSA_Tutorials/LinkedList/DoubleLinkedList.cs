using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Tutorials.LinkedList
{
    public class DoubleLinkedList<AnyType>
    {
        //this is the start node of the linked list chain
        Node<AnyType> head = null;
        //tail of link list
        Node<AnyType> tail = null;
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
                newItem.previous = tail;
                tail = newItem;
            }
        }

        public void AddFirst(AnyType data)
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
                newItem.next = head;
                head.previous = newItem;
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

                if (currentNodePosition == StartNode)
                {
                    newItem.next = current.next;
                    if(current.next != null)
                    {
                        current.next.previous = newItem;
                    }
                    current.next = newItem;
                    newItem.previous = current;

                    if(current == tail)
                    {
                        tail = newItem;
                    }
                }
                else
                {
                    tail.next = newItem;
                    newItem.previous = tail;
                    tail = newItem;
                }
            }
        }

        public void ReadForward()
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

        public void ReadReverse()
        {
            Node<AnyType> currentNode = tail;
            //loop until the last node
            //display data
            while (currentNode.previous != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.previous;
            }
            Console.WriteLine(currentNode.data);
        }
    }
}
