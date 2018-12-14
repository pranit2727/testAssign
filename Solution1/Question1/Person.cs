using System;

namespace Question1
{
    public class Person
    {
        public string Name;
        public int Age;

        //Constructor of Person class
        public Person()
        {
            Name = "Rohit";
            Age = 10;
        }
        
    }
    
    public class Employee : Person
    {
        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        public int age
        {
            get { return this.Age; }
            set { this.Age = value; }
        }

   
        //printing the value of person
        public void Print()
        {
            Console.WriteLine("The name of person is {0} and age is {1} \n", name, age);
        }


    }


    public class mainMethod
    {
        public static void Main(string[] args)
        {
            //Setting the value of person through employee class
            Employee emp = new Employee();
            emp.name = "abhi";
            emp.age = 24;
            emp.Print();

            //Object of calculator class is created and invoking base class's method
            Calculator baseClassObj;
            baseClassObj = new Calculator();
            Console.WriteLine("Base class method Calculate and sum is  :" + baseClassObj.Calculate(3, 8));

            //Object of childClass is created and invoking derived class's method
            baseClassObj = new ChildClass();
            Console.WriteLine("Child class method Calculate and multiplication is:" + baseClassObj.Calculate(3, 8));
            Console.ReadKey();
        }

    }
}

