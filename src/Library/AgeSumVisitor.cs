using System;
namespace Library
{
    /// <summary>
    /// Visitor que calcula la suma de las edades de todo el arbol genealogico.
    /// Creado por patron visitor.
    /// </summary>
    public class AgeSumVisitor : Visitor
    {
        int sum = 0;
        public override void Visit(Node n)
        {
            sum += n.Person.Age;
            foreach (Node child in n.Children)
            {
                child.Accept(this);
            }
            this.content = sum.ToString();
        }
    }
}