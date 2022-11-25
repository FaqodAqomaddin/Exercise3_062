using System;

namespace Exercise_Linked_List_C
{
    class Node
    {
        /*Node class respresent the node of doubly linked list
         * it consists of the information part and link to
         * its succeding and preceeding
         * in term of next and previous */
        public int noMhs;
        public string name;
        //point to the succeding node
        public Node next;
        public Node prev;
    }
    class DoubleLinkedList
    {
        Node START;

        //constructor

        public void addNote()
        {
            int nim;
            string nm;
            Console.WriteLine("\nEnter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm;

            //check if the list empty
            if (START == null || nim <= START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nDuplicate number not allowed");
                    return;
                }
                newNode.next = START;
                if (START != null)
                    START.prev = newNode;
                newNode.next = null;
                START = newNode;
                return;
            }
        }
    }
}