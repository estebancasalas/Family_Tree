using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private Person person;

        private List<Node> children = new List<Node>();

        public Person Person {
            get
            {
                return this.person;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(string name, string lastName, int age)
        {
            Person person = new Person(name,lastName,age);
            this.person = person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        
    }
}
