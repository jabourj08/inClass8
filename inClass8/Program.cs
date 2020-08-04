using System;
using System.Collections.Generic;
using System.Linq;

namespace inClass8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(25);
            numbers.Add(500);
            numbers.Add(122);
            numbers.Add(2);
            numbers.Add(320);
            numbers.Add(401);
            numbers.Add(13);

            Console.WriteLine("The biggest number in my list is: " + ReturnMax(numbers));
            Console.WriteLine("The smallest number in my list is: " + ReturnMin(numbers));
        }

        public static int ReturnMax(List<int> numbers)
        {
            int max = numbers.Max();
            int notCheatingMax = numbers[0];

            for (int i = 0; i < numbers.Count; i++)
            {
                
                if (numbers[i] > notCheatingMax)
                {
                    notCheatingMax = numbers[i];
                }
            }

            return notCheatingMax;
        }
        public static int ReturnMin(List<int> numbers)
        {
            int min = numbers.Min();

            for (int i = 0; i < numbers.Count; i++)
            {

            }

            return min;
        }
    }


    public class Animal
    {
        //fields - private (only accessible within this class)

        private string name;
        private string type;
        private bool fluffy;
        private int age;

        //Properties - public(accessible outside of this class)
        // non-static: tied to an object (for us to access the properties within this class, we must create a new object)

        public string Name
        {
            //getters - allows us to retieve the value of our property
            get
            {
                return name;
            }

            //setters - set the value of our property through the field
            set
            {
                name = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public bool Fluffy
        {
            get
            {
                return fluffy;
            }

            set
            {
                fluffy = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        //CONSTRUCTORS
        //Default
        public Animal()
        {

        }

        //Overloaded Constructor
        public Animal(string Name, string Type, bool Fluffy, int Age)
        {
            name = Name;
            type = Type;
            fluffy = Fluffy;
            age = Age;
        }
    }
}
