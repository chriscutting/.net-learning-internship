using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IT232Unit4Cutting
{
    class Program
    {
        struct structCar
        {
            public string make;
            public string model;
            public int modelYear;
        }

        static void Main(string[] args)
        {
            //Assignment 4 section one.
            //Let's make some arrays/objects
            //Array of strcutures
            structCar[] cars = new structCar[3];
            //add values to array
            cars[0] = new structCar();
            cars[0].make = "Ford";
            cars[0].model = "Mustang";
            cars[0].modelYear = 2010;

            cars[1] = new structCar();
            cars[1].make = "Chevrolet";
            cars[1].model = "Silverado";
            cars[1].modelYear = 2008;

            cars[2] = new structCar();
            cars[2].make = "Dodge";
            cars[2].model = "Charger";
            cars[2].modelYear = 2012;

            Console.WriteLine("Section 1: An array of structures");

            //Display all of the strcutures
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i].make + " " + cars[i].model + " " + cars[i].modelYear);

            }
            //Make a dictionary that uses the car model as a key 
            Dictionary<string, int> inventoryCount = new Dictionary<string, int>();
            //Populate the dictionary
            inventoryCount.Add("Mustang", 9);
            inventoryCount.Add("Silverado", 13);
            inventoryCount.Add("Charger", 4);

            Console.WriteLine();
            Console.WriteLine("Section 2: Inventory Count");

            //Display inv count from dictionary

            Console.WriteLine("There are " + inventoryCount["Mustang"] + " Mustangs.");
            Console.WriteLine("There are " + inventoryCount["Silverado"] + " Silverados.");
            Console.WriteLine("There are " + inventoryCount["Charger"] + " Chargers.");

            //Assignment 4, Section 3

            //make an ArrayList

            ArrayList daysOfWeek = new ArrayList();
            daysOfWeek.Add("Sunday");
            daysOfWeek.Add("Monday");
            daysOfWeek.Add("Tuesday");
            daysOfWeek.Add("Wednesday");
            daysOfWeek.Add("Thursday");
            daysOfWeek.Add("Friday");
            daysOfWeek.Add("Saturday");

            Console.WriteLine();
            Console.WriteLine("Days of the week");

            //Display the arraylist

            for (int i = 0; i < daysOfWeek.Count; i++)
            {
                Console.WriteLine(daysOfWeek[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Days of the week, but in reverse");


            //The same thing, but backwards

            for (int i = daysOfWeek.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(daysOfWeek[i]);
            }
            //Copy into another ArrayList

            ArrayList workDays = new ArrayList();
            workDays.AddRange(daysOfWeek);

            //Remove sat/sun

            workDays.Remove("Saturday");
            workDays.Remove("Sunday");

            Console.WriteLine();
            Console.WriteLine("Work days:");

            for (int i = 0; i < workDays.Count; i++)
            {
                Console.WriteLine(workDays[i]);
            }
            //Assignment 4 Section 4


            Console.WriteLine();
            Console.WriteLine("Section 4: Stack");

            //make a stack

            Stack<int> myStack = new Stack<int>();

            //Push things into it.

            myStack.Push(10);
            myStack.Push(24);
            myStack.Push(31);
            myStack.Push(45);
            myStack.Push(19);
            myStack.Push(76);

            //How many items?

            Console.WriteLine("There are " + myStack.Count + " items on the stack");

            //Change that.

            myStack.Pop();
            myStack.Pop();
            myStack.Pop();

            //What about now?

            Console.WriteLine("Now there are " + myStack.Count + " items on the stack");

            //Check the next item

            Console.WriteLine("the next item to be Popped is " + myStack.Peek() + ".");


            //Assignment 4, Section 5

            Console.WriteLine();
            Console.WriteLine("Section 5: Queues");

            Queue<int> q = new Queue<int>();

            //Enqueue some things..

            q.Enqueue(10);
            q.Enqueue(24);
            q.Enqueue(35);
            q.Enqueue(45);
            q.Enqueue(19);
            q.Enqueue(76);

            Console.WriteLine("There are " + q.Count + " items in the Queue");

            //DeQueue some things.

            q.Dequeue();
            q.Dequeue();
            q.Dequeue();

            //What's in the Queue now?

            Console.WriteLine("There are " + q.Count + " items in the Queue.");

            //What's the next thing to be DeQued?

            Console.WriteLine("The next item to be DeQued is " + q.Peek() + ".");

            Console.ReadLine();


        }
    }
}
