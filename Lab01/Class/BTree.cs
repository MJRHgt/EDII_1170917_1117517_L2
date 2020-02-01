using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01.Class
{
    class BTree<Tkey, T> where Tkey : IComparable<Tkey>
    {

        //-------------------------CLASS KEY AND VALUE TO INSERT----------------------
        private class Value : IEquatable<Value>
        {
            public Tkey key { get; set; }
            public T Value_Val { get; set; }

            public int line;

            // method builder
            public Value(Tkey newKey, T newValue, int newLine)
            {
                key = newKey;
                Value_Val = newValue;
                line = newLine;
            }

            // method Equals
            public bool Equals(Value other)
            {
                return key.Equals(other.key) && Value_Val.Equals(other.Value_Val);
            }

        } // end class Value


        //-------------------------- CLASS NODE  -------------------------------------------
        private class Node
        {
            int Grade; //Know grade the tree
            public LinkedList<Node> Sons { get; set; } 
            public LinkedList<Value> Entries { get; set; }

            //Method builder
            public Node(int grade)
            {
                Sons = new LinkedList<Node>();
                Entries = new LinkedList<Value>();
                Grade = grade;
            }


        } // end class Node

    } //end class BTree
}
