using System;
using System.Collections.Generic;
using System.Linq;

namespace A_C_assessment1
{
    public class sorting
    {
        Roads r = new Roads();
        public (List<int>, List<int>) sort(List<int> Road)
        {
            r.count = 0;
            List<int> asortedRoad = ascending(Road);
            Console.WriteLine("Sorted in ascending numbers:");
            r.output(asortedRoad);
            if (Road.Count == 256)
            {
                Console.WriteLine($"The 10th value of this list is {asortedRoad[9]}");
            }
            else if (Road.Count == 2048)
            {
                Console.WriteLine($"The 50th value of this list is {asortedRoad[49]}");
            }
            Console.WriteLine($"This bubble sort took {r.count} steps.");

            r.count = 0;
            List<int> dsortedRoad = descending(Road);
            dsortedRoad.Reverse();
            Console.WriteLine("Sorted in descending numbers:");
            r.output(dsortedRoad);
            Console.WriteLine($"This merge sort took {r.count} steps");
            return (asortedRoad, dsortedRoad);
        }
        public List<int> ascending(List<int> toSort)
        {
            int n = toSort.Count;
            for (int k = 0; k < n; k++)   //loops 256 (or the amount of numbers in the list) times
            {
                for (int l = 0; l < n - 1; l++)    //Same as above but minus 1
                {

                    if (toSort[l] > toSort[l + 1])   //If whatever number it is on is more than the one above it ...
                    {
                        int a = toSort[l + 1];   // ... Puts the one above into a temp variable
                        toSort[l + 1] = toSort[l];   //Puts below into above
                        toSort[l] = a;    //Puts above into below
                    }  //^^^ essentially swaps the two numbers
                    r.count += 1;   //Counting how many steps
                }
            }
            return toSort;
        }

        public List<int> descending(List<int> toSort)    //merge sort to show the effectiveness between the two algorithms
        {
            r.count += 1;
            List<int> left = new List<int>();   //Making two lists to split the list into 
            List<int> right = new List<int>();

            int n = toSort.Count;
            if (n <= 1)
            {
                return toSort;
            }

            int center = n / 2;    //Finds the center of the list

            for (int i = 0; i < center; i++)
            {
                left.Add(toSort[i]);
            }
            //Splits the list into two halves
            for (int i = center; i < n; i++)
            {
                right.Add(toSort[i]);
            }

            left = descending(left);
            right = descending(right);
            return descendingp2(left, right);


        }
        public List<int> descendingp2(List<int> left, List<int> right)
        {
            List<int> all_together = new List<int>();
            while (left.Count > 0 || right.Count > 0)            //While one list or the other has one or more items
            {
                if (left.Count > 0 && right.Count > 0)            //If both are more than 0
                {
                    if (left.First() <= right.First())      //If first item in left is smaller thanfirst item in right
                    {
                        all_together.Add(left.First());     //Add the first item in left to the end list
                        left.Remove(left.First());      //Remove first item from left list so it isnt added again
                    }
                    else
                    {
                        all_together.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)              //If right has 0 items but left doesnt 
                {
                    all_together.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)             //If left has 0 items but right doesnt 
                {
                    all_together.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return all_together;
        }
    }
}
