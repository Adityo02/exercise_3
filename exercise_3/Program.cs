using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
    class Node
    {
        /*create Nodes for the circuar nexted list*/
        public int rollNumber;
        public string name;
        public Node next;
    }
    class CircularList
    {
        Node LAST;

        public CircularList()
        {

        }
        public bool Search(int rollNo, ref Node previous, ref Node current)
        /*Searches for the specified node*/
        {
            for (previous = current =LAST.next; current != LAST; previous =
                current, current = current.next)

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
