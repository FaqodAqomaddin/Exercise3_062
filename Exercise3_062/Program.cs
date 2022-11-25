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
}