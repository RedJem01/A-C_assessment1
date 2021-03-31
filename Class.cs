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
            Console.WriteLine("Road 1 (256):");
            for (int i = 0; i <= Road_1.Count; i++)
            {
                Console.WriteLine(i + " ");
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
		//public void sorting()
  //      {
  //          Console.WriteLine("Road 1 (256):");
  //          for (int i = 0; i <= Road_1.Count; i++)
  //          {
  //              Console.WriteLine(i + " ");
  //          }
  //          for (int k = 0; k <= Road_1.Count - 2; k++)
  //          {
  //              for (int l = 0; l <= Road_1.Count - 2; k++)
  //              {
  //                  if (Road_1[l] > Road_1[l + 1])
  //                  {
  //                      int a = Road_1[l + 1];
  //                      Road_1[l + 1] = Road_1[l];
  //                      Road_1[l] = a;

  //                      Console.WriteLine("Road_1 (256) sorted:");
  //                      for (int p = 0; p <= Road_1.Count; p++)
  //                      {
  //                          Console.WriteLine(p + " ");
  //                      }
  //                  }
  //              }
  //          }
  //      }
	}
}
