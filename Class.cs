using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace A_C_assessment1
{
	class Roads
	{
        private List<int> _Road_1;
        public List<int> Road_1
        {
            get { return _Road_1; }
            set { _Road_1 = value; }
        }

        private List<int> _Road_2;
        public List<int> Road_2
        {
            get { return _Road_2; }
            set { _Road_2 = value; }
        }

        private List<int> _Road_3;
        public List<int> Road_3
        {
            get { return _Road_3; }
            set { _Road_3 = value; }
        }
        
        public Roads()
        {
            Road_1 = new List<int>();
            Road_2 = new List<int>();
            Road_3 = new List<int>();
        }

        public void read()
        {
            string path = Path.GetFullPath("Road_1_256.txt");   //Gets the file path for the text file
            string[] text = File.ReadAllLines(path);    //Reads all the data in the text file to a varaible
            for (int i = 0; i < text.Length; i++)   //Loops through the data in the text file 
            {
                Road_1.Add(int.Parse(text[i]));    //Adds each number in it to a list
            }

            path = Path.GetFullPath("Road_2_256.txt"); 
            text = File.ReadAllLines(path);
            for (int i = 0; i < text.Length; i++)
            {
                Road_2.Add(int.Parse(text[i]));
            }

            path = Path.GetFullPath("Road_3_256.txt");
            text = File.ReadAllLines(path);
            for (int i = 0; i < text.Length; i++)
            {
                Road_3.Add(int.Parse(text[i]));
            }

        }
        public void search()
        {

        }
        public List<int> ascending(List<int> toSort)
        { 
            int count = 0;   //To see how many steps the algorithm does
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
                    count += 1;   //Counting how many steps
                }
            }
            Console.WriteLine("Sorted in ascending numbers:");
            for (int p = 0; p < toSort.Count; p++)
            {
                Console.WriteLine(toSort[p] + " ");    //Outputting the sorted list
            }
            Console.WriteLine($"The 10th value of this list is {toSort[9]}");  
            Console.WriteLine($"This bubble sort took {count} steps.");
            return toSort;
        }
        public List<int> descending(List<int> toSort)
        {
            List<int> left = new List<int>(); 
            List<int> right = new List<int>();
            int n = toSort.Count;   
            int center = n / 2;


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
            all_together.Reverse();
            Console.WriteLine("Sorted in descending numbers:");
            for (int p = 0; p < all_together.Count; p++)
            {
                Console.WriteLine(all_together[p] + " ");    //Outputting the sorted list
            }

            return all_together;
        }
    }
}
