using System;
using System.Collections.Generic;


namespace A_C_assessment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Roads r = new Roads();
            r.read();
            Console.WriteLine("Road 1 (256):");
            foreach (int i in r.Road_1)
            {
                Console.WriteLine(r.Road_1[i] + " ");
            }
            List<int> asortedRoad_1 = r.ascending(r.Road_1);
             r.descending(r.Road_1);

            //Console.WriteLine("Road 2 (256):");
            //foreach (int i in r.Road_2)
            //{
            //    Console.WriteLine(r.Road_2[i] + " ");
            //}
            //List<int> asortedRoad_2 = r.ascending(r.Road_2);
            ////List<int> dsortedRoad_2 = r.descending(r.Road_2);

            //Console.WriteLine("Road 3 (256):");
            //foreach (int i in r.Road_3)
            //{
            //    Console.WriteLine(r.Road_3[i] + " ");
            //}
            //List<int> asortedRoad_3 = r.ascending(r.Road_3);
            ////List<int> dsortedRoad_3 = r.descending(r.Road_3);
        }
    }
}