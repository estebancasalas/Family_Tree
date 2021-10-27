using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Node n1 = new Node("manuel perez",20);
            Node n2 = new Node("martin perez",50);
            Node n3 = new Node("jose perez",62);
            Node n4 = new Node("juan perez",48);
            Node n5 = new Node("Ana Pereyra de Souza", 62);
            Node n6 = new Node("Andres Casalas", 29);
            Node n7 = new Node("Esteban Casalas", 21);
            Node n8 = new Node("pedro perez", 15);
            
            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n2.AddChildren(n4);
            n2.AddChildren(n5);
            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí
            AgeSumVisitor AgeSum = new AgeSumVisitor();
            AgeSum.Visit(n1);
            Console.WriteLine(AgeSum.Content);
            EldestVisitor Eldest = new EldestVisitor();
            Eldest.Visit(n1);
            Console.WriteLine(Eldest.Content);
            LongestNameVisitor LongestName = new LongestNameVisitor();
            LongestName.Visit(n1);
            Console.WriteLine(LongestName.Content);
        }
    }
}
