using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IT232Unit3CCutting
{
    class Program
    {
        static void Main(string[] args)
        {
            //*************************
            //Assignment 3 section 1
            //*************************

            //Make an array var

            string[,] salesRegions;
            salesRegions = new string[4,4];


            //Notes from prof: 3d+ Arrays pull row first, then column, because the 'row' is another array

            //Populate salesRegions for column1

            salesRegions[0, 0] = "North";
            salesRegions[1, 0] = "South";
            salesRegions[2, 0] = "East";
            salesRegions[3, 0] = "West";

            //Pupulate salesReps for column 2

            salesRegions[0, 1] = "Bob";
            salesRegions[0, 2] = "Steph";
            salesRegions[0, 3] = "Ron";

            salesRegions[1, 1] = "Sue";
            salesRegions[1, 2] = "Janice";
            salesRegions[1, 3] = "Will";

            salesRegions[2, 1] = "Nathan";
            salesRegions[2, 2] = "Henry";
            salesRegions[2, 3] = "Kimmy";

            salesRegions[3, 1] = "Wanda";
            salesRegions[3, 2] = "Charles";
            salesRegions[3, 3] = "Pete";

            Console.WriteLine("Two-dimensional array");

            //Make nested loops to display contents of 3d array

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.WriteLine(salesRegions[row, col]);
                }
                Console.WriteLine("");
            }



            //UNIT 3 Assignment Section 2



            ArrayList salesTeam = new ArrayList();

                for (int col = 1; col < 4; col++)
                {
                salesTeam.Add(salesRegions[0, col]);

                }

            Console.WriteLine("Section 2 Array List");
            Console.WriteLine("");

            //Display current elements in salesTeam Array

            Console.Write("There are " + salesTeam.Count.ToString() + " names in the salesTeam arrayList");

            //add the south region

            for (int col = 1; col < 4; col++)
            {
                salesTeam.Add(salesRegions[1, col]);
                Console.WriteLine("");

            }

            //Check for 'steph' in the list

            if (salesTeam.Contains("Steph"))
            {
                System.Console.WriteLine("Steph is in the list!");
            }

            else
            {
                System.Console.WriteLine("Steph is not in the list!");
            }

            //Display number of items in arraylist

            Console.WriteLine("There are" + salesTeam.Count.ToString() + " people in the array list");

            //Drop Janice and Ronny

            salesTeam.Remove("Janice");
            salesTeam.Remove("Ron");

            //Display the new number of names

            Console.WriteLine("There are now" + salesTeam.Count.ToString() + " people in the array list");

            //Actually display the current names

            Console.WriteLine("Names currently in the arrayList are:");

            for (int i = 0; i < salesTeam.Count; i++)
            {
                Console.WriteLine(salesTeam[i]);

            }

            Console.Read();
             


















        }
    }
}
