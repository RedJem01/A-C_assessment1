using System;
using System.Collections.Generic;


namespace A_C_assessment1
{
    class WrongInputException : Exception
    {
        public WrongInputException(string message) : base(message)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Roads r = new Roads();   //Creating a new object 
            sorting so = new sorting();
            searching se = new searching();

            r.read();

            Console.WriteLine("Road 1 (256):");
            r.output(r.Road_1);

            (List<int> asortedRoad_1, List<int> dsortedRoad_1) = so.sort(r.Road_1);

            Console.WriteLine("Road 2 (256):");
            r.output(r.Road_2);

            (List<int> asortedRoad_2, List<int> dsortedRoad_2) = so.sort(r.Road_2);

            Console.WriteLine("Road 3 (256):");
            r.output(r.Road_3);

            (List<int> asortedRoad_3, List<int> dsortedRoad_3) = so.sort(r.Road_3);

            try
            {


                Console.WriteLine("Which road did you want to look at?");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    string found = se.search(asortedRoad_1);
                    if (found == "Error: The number you searched for is not in the list")
                    {
                        Console.WriteLine(found);
                    }
                    else
                    {
                        Console.WriteLine($"The number you searched for is in position {found}");
                    }
                }
                else if (choice == "2")
                {
                    string found = se.search(asortedRoad_2);
                    if (found == "Error: The number you searched for is not in the list")
                    {
                        Console.WriteLine(found);
                    }
                    else
                    {
                        Console.WriteLine($"The number you searched for is in position {found}");
                    }
                }
            
                else if (choice == "3")
                {
                    string found = se.search(asortedRoad_3);
                    if (found == "Error: The number you searched for is not in the list")
                    {
                        Console.WriteLine(found);
                    }
                    else
                    {
                        Console.WriteLine($"The number you searched for is in position {found}");
                    }
                }
            
                else
                {
                    throw new WrongInputException("That is the wrong input. Please input 1, 2 or 3.");

                }
            }
            catch (WrongInputException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
    