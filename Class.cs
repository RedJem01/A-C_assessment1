using System;
using System.Collections.Generic;
using System.IO;


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
            string path = Path.GetFullPath("Road_1_256.txt");
            string[] text = File.ReadAllLines(path);
            for (int i = 0; i < text.Length; i++)
            {
                Road_1.Add(int.Parse(text[i]));
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
            int count = 0;
            int n = toSort.Count;
            for (int k = 0; k < n; k++)
            {
                //Console.WriteLine($"k{k}");
                for (int l = 0; l < n; l++)
                {
                    //Console.WriteLine($"k{k}");

                    if (toSort[l] > toSort[k])
                    {
                        //Console.WriteLine($"k{k}");
                        int a = toSort[k];
                        toSort[k] = toSort[l];
                        toSort[l] = a;
                    }
                    count += 1;
                }
            }
            Console.WriteLine("Sorted in ascending numbers:");
            foreach (int p in toSort)
            {
                Console.WriteLine(toSort[p]);
            }
            Console.WriteLine($"The 10th value of this list is {toSort[10]}");
            Console.WriteLine($"This bubble sort took {count} steps.");
            return toSort;
        }
        public List<int> descending(List<int> toSort)
        {
            return toSort;
        }
    }
}
