namespace Library
{
    public abstract class Visitor
    {
        public int Age
        {
            get
            {
                return this.age;
            }
        }

        protected int age {get;} = 0;

        public abstract void Visit(Node n);
    }
}