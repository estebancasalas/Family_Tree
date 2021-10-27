using System;
namespace Library
{
    /// <summary>
    /// Visitor que guarda la edad de la hoja con la mayor edad del arbol.
    /// Creado por patron Visitor.
    /// </summary>
    public class LongestNameVisitor : Visitor
    {
        public override void Visit(Node n)
        {
            if (this.Content.Length < n.Person.Name.Length)
            {
                this.content = n.Person.Name;
            }
            foreach (Node child in n.Children)
            {
                child.Accept(this);
            }
        }
    }
}