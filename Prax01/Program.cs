using System;
using Domain;

namespace Prax01
{
    public class Class1
    {
        public static void Main(String[] args)
        {
            Person person1 = new Person("William", "Straus");
            Person person2 = new Person("Tero", "Taskila", "Teroste");
            
            Console.WriteLine("Person1 FirstName: " + person1.FirstName + " LastName: " + person1.LastName);
            Console.WriteLine("Person: " + person2);
            Console.WriteLine("Person: " + person1);
        }
    }
}