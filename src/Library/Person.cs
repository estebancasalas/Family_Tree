namespace Library
{
    public class Person
    {
        private string name { get; set;}
        private string lastName { get; set;}
        private int age { get; set;}

        public Person(string name, string lastName, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }
    }
}