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

            //reading files in
            r.read();

            //sorting files
            Console.WriteLine("Road 1 (256):");
            r.output(r.Road_1);
            (List<int> asortedRoad_1, List<int> dsortedRoad_1) = so.sort(r.Road_1);

            Console.WriteLine("Road 2 (256):");
            r.output(r.Road_2);
            (List<int> asortedRoad_2, List<int> dsortedRoad_2) = so.sort(r.Road_2);

            Console.WriteLine("Road 3 (256):");
            r.output(r.Road_3);
            (List<int> asortedRoad_3, List<int> dsortedRoad_3) = so.sort(r.Road_3);

            Console.WriteLine("Road 1 (2048):");
            r.output(r.Road_1_);
            (List<int> asortedRoad_1_, List<int> dsortedRoad_1_) = so.sort(r.Road_1_);

            Console.WriteLine("Road 2 (2048):");
            r.output(r.Road_2_);
            (List<int> asortedRoad_2_, List<int> dsortedRoad_2_) = so.sort(r.Road_2_);

            Console.WriteLine("Road 3 (2048):");
            r.output(r.Road_3_);
            (List<int> asortedRoad_3_, List<int> dsortedRoad_3_) = so.sort(r.Road_3_);

            //merging and sorting merged files
            Console.WriteLine("Road 1 and Road 3 merged (256)");
            List<int> merged256 = r.merge(asortedRoad_1, asortedRoad_3);
            r.output(merged256);
            (List<int> asortedmerge256, List<int> dsortedmerge256) = so.sort(merged256);

            Console.WriteLine("Road 1 and Road 3 merged (2048)");
            List<int> merged2048 = r.merge(asortedRoad_1_, asortedRoad_3_);
            r.output(merged2048);
            (List<int> asortedmerge2048, List<int> dsortedmerge2048) = so.sort(merged2048);


            //searching for a num in files
            try
            {
                Console.WriteLine("Which road did you want to look at? 1,2,3 are 256 4,5,6 are 2048 7,8 are merged 256 and merged 2048");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    string found = se.search(asortedRoad_1);
                    if (se.inPosition == false)
                    {
                        Console.WriteLine($"The number you searched for is not in the list. The closest number is {found} and it is in the position {se.position}");
                    }
                    else
                    {
                        Console.WriteLine($"The number you searched for is in position {found}");
                    }
                }
                else if (choice == "2")
                {
                    string found = se.search(asortedRoad_2);
                    if (se.inPosition == false)
                    {
                        Console.WriteLine($"The number you searched for is not in the list. The closest number is {found} and it is in the position {se.position}");
                    }
                    else
                    {
                        Console.WriteLine($"The number you searched for is in position {found}");
                    }
                }

                else if (choice == "3")
                {
                    string found = se.search(asortedRoad_3);
                    if (se.inPosition == false)
                    {
                        Console.WriteLine($"The number you searched for is not in the list. The closest number is {found} and it is in the position {se.position}");
                    }
                    else
                    {
                        Console.WriteLine($"The number you searched for is in position {found}");
                    }
                }

                else if (choice == "4")
                {
                    string found = se.search(asortedRoad_1_);
                    if (se.inPosition == false)
                    {
                        Console.WriteLine($"The number you searched for is not in the list. The closest number is {found} and it is in the position {se.position}");
                    }
                    else
                    {
                        Console.WriteLine($"The number you searched for is in position {found}");
                    }
                }

                else if (choice == "5")
                {
                    string found = se.search(asortedRoad_2_);
                    if (se.inPosition == false)
                    {
                        Console.WriteLine($"The number you searched for is not in the list. The closest number is {found} and it is in the position {se.position}");
                    }
                    else
                    {
                        Console.WriteLine($"The number you searched for is in position {found}");
                    }
                }

                else if (choice == "6")
                {
                    string found = se.search(asortedRoad_3_);
                    if (se.inPosition == false)
                    {
                        Console.WriteLine($"The number you searched for is not in the list. The closest number is {found} and it is in the position {se.position}");
                    }
                    else
                    {
                        Console.WriteLine($"The number you searched for is in position {found}");
                    }
                }

                else if (choice == "7")
                {
                    string found = se.search(asortedmerge256);
                    if (se.inPosition == false)
                    {
                        Console.WriteLine($"The number you searched for is not in the list. The closest number is {found} and it is in the position {se.position}");
                    }
                    else
                    {
                        Console.WriteLine($"The number you searched for is in position {found}");
                    }
                }

                else if (choice == "8")
                {
                    string found = se.search(asortedmerge2048);
                    if (se.inPosition == false)
                    {
                        Console.WriteLine($"The number you searched for is not in the list. The closest number is {found} and it is in the position {se.position}");
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
                Console.WriteLine(e.Message);   //If wrong input is inputted write an error message and exit
            }
        }
    }
}
    