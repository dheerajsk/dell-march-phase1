using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Strcuture
{
    class LinkedList
    {
        Node head;

        public void Do()
        {
            LinkedList list = new LinkedList();
            // Insert a node.
            // 23, 56, 43, 90, 12
            var head = new Node(23);
            list.head = head;
            var result56 = list.Insert(list.head, 56);
            var result43 = list.Insert(result56, 43);
            var result90 = list.Insert(result43, 90);
            list.Insert(result90, 92);
            list.Print(list);
            list.Delete(result43, result56);
            list.head = head;
            list.Print(list);
            Console.Read();
        }

        Node Insert(Node head, int num)
        {
            Node node2 = new Node(num);
            head.next = node2;
            return node2;
        }

        void Delete(Node nodeToDelete, Node previousNode)
        { // 23->56->43->90->92
            // delete43, previous56 (56->43)
            // after delete :  56-> 90
            // 23->56->90->92
            previousNode.next = nodeToDelete.next;
        }

        void Print(LinkedList list)
        {
            while (list.head != null)
            {
                Console.WriteLine(list.head.value + " ->");
                list.head = list.head.next;
            }
        }
    }

    class Node
    {
        public int value;
        public Node next;

        public Node(int d)
        {
            value = d;
            next = null;
        }
    }
}
