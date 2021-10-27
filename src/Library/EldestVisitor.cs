using System;
namespace Library
{
    /// <summary>
    /// Visitor que guarda la edad de la hoja con la mayor edad del arbol.
    /// Creado por patron Visitor.
    /// </summary>
    public class EldestVisitor : Visitor
    {
        int HighestAge = 0;
        public override void Visit(Node n)
        {
            if (n.Children.Count == 0)
            {
                if (HighestAge < n.Person.Age)
                {
                    HighestAge = n.Person.Age;
                }
            }
            else
            {
                foreach (Node child in n.Children)
                {
                    child.Accept(this);
                }
            }
            this.content = HighestAge.ToString();
            
        }
    }
}