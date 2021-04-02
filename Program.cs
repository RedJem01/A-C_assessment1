using System;
using System.Collections.Generic;


namespace A_C_assessment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Roads r = new Roads();   //Creating a new object 
            r.read();

            Console.WriteLine("Road 1 (256):");
            r.output(r.Road_1);

            List<int> asortedRoad_1 = r.ascending(r.Road_1);
            Console.WriteLine("Sorted in ascending numbers:");
            r.output(asortedRoad_1);
            Console.WriteLine($"The 10th value of this list is {asortedRoad_1[9]}");
            Console.WriteLine($"This bubble sort took {r.count} steps.");


            List<int> dsortedRoad_1 = r.descending(r.Road_1);
            dsortedRoad_1.Reverse();
            Console.WriteLine("Sorted in descending numbers:");
            r.output(dsortedRoad_1);
            Console.WriteLine($"The tenth value is {dsortedRoad_1[246]}");
            Console.WriteLine($"This merge sort took {r.count} steps");



            Console.WriteLine("Road 2 (256):");
            r.output(r.Road_2);

            List<int> asortedRoad_2 = r.ascending(r.Road_2);
            Console.WriteLine("Sorted in ascending numbers:");
            r.output(asortedRoad_2);
            Console.WriteLine($"The 10th value of this list is {asortedRoad_2[9]}");
            Console.WriteLine($"This bubble sort took {r.count} steps.");


            List<int> dsortedRoad_2 = r.descending(r.Road_2);
            dsortedRoad_2.Reverse();
            Console.WriteLine("Sorted in descending numbers:");
            r.output(dsortedRoad_2);
            Console.WriteLine($"The tenth value is {dsortedRoad_2[246]}");
            Console.WriteLine($"This merge sort took {r.count} steps");

            Console.WriteLine("Road 3 (256):");
            r.output(r.Road_3);

            List<int> asortedRoad_3 = r.ascending(r.Road_3);
            Console.WriteLine("Sorted in ascending numbers:");
            r.output(asortedRoad_3);
            Console.WriteLine($"The 10th value of this list is {asortedRoad_3[9]}");
            Console.WriteLine($"This bubble sort took {r.count} steps.");

            List<int> dsortedRoad_3 = r.descending(r.Road_3);
            dsortedRoad_3.Reverse();
            Console.WriteLine("Sorted in descending numbers:");
            r.output(dsortedRoad_3);
            Console.WriteLine($"The tenth value is {dsortedRoad_3[246]}");
            Console.WriteLine($"This merge sort took {r.count} steps");
        }
    }
}