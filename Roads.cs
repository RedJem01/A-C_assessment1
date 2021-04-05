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

        private int _count;
        public int count
        {
            get { return _count; }
            set { _count = value; }
        }

        private List<int> _Road_1_;
        public List<int> Road_1_
        {
            get { return _Road_1_; }
            set { _Road_1_ = value; }
        }

        private List<int> _Road_2_;
        public List<int> Road_2_
        {
            get { return _Road_2_; }
            set { _Road_2_ = value; }
        }

        private List<int> _Road_3_;
        public List<int> Road_3_
        {
            get { return _Road_3_; }
            set { _Road_3_ = value; }
        }

        public Roads()
        {
            Road_1 = new List<int>();
            Road_2 = new List<int>();
            Road_3 = new List<int>();
            Road_1_ = new List<int>();
            Road_2_ = new List<int>();
            Road_3_ = new List<int>();
        }

        public void output(List<int> list)
        {
            list.ForEach(Console.WriteLine);
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

            path = Path.GetFullPath("Road_1_2048.txt");
            text = File.ReadAllLines(path);
            for (int i = 0; i < text.Length; i++)
            {
                Road_1_.Add(int.Parse(text[i]));
            }

            path = Path.GetFullPath("Road_2_2048.txt");
            text = File.ReadAllLines(path);
            for (int i = 0; i < text.Length; i++)
            {
                Road_2_.Add(int.Parse(text[i]));
            }

            path = Path.GetFullPath("Road_3_2048.txt");
            text = File.ReadAllLines(path);
            for (int i = 0; i < text.Length; i++)
            {
                Road_3_.Add(int.Parse(text[i]));
            }
        }

        public List<int> merge(List<int> list1, List<int> list2)
        {
            List<int> newList;
            newList = new List<int>();
            foreach (int i in list1)
            {
                newList.Add(i);
            }
            foreach (int i in list2)
            {
                newList.Add(i);
            }
            return newList;

        }
    }
}
