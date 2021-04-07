using System;
using System.Collections.Generic;
using System.Linq;

namespace A_C_assessment1
{
    public class searching
    {
        //Class attributes
        private bool _inPosition;
        public bool inPosition
        {
            get { return _inPosition; }
            set { _inPosition = value; }
        }

        private int _position;
        public int position
        {
            get { return _position; }
            set { _position = value; }
        }

        Roads r = new Roads();    //Making a roads object
        public string search(List<int> toSearch)
        {
            Console.WriteLine("Please input a number.");
            string num = Console.ReadLine();      //Getting number to find
            int number = int.Parse(num);
            r.count = 0;
            if (toSearch.Count == 2048)
            {
                int start = 0;
                int stop = toSearch.Count;
                string ret = binarySearch(toSearch, start, stop, number);   //calling search algorithm
                Console.WriteLine($"This binary search took {r.count} steps");
                return ret;
            }
            else
            {
                string ret = interpolationSearch(toSearch, number);
                Console.WriteLine($"This interpolation search took {r.count} steps");
                return ret;
            }

        }

        public string binarySearch(List<int> toSearch, int start, int stop, int number)
        {
            r.count += 1;
            inPosition = true;
            position = 0;
            if (start > stop)     //If havent found the number by the end of the list
            {
                int nearest = nearestToValue(toSearch, number);   //call function to find nearest value
                inPosition = false;    //Number is not in list so its false
                return nearest.ToString();
            }
            if (number < toSearch[0])    //If the number is smaller than the first num in list
            {
                string pos = (toSearch[0].ToString());    //make pos the first number
                inPosition = false;   
                position = 1;
                return pos;
            }
            else if (number > toSearch[toSearch.Count - 1])   //if number is bigger than biggest num in list
            {
                string pos = (toSearch[toSearch.Count - 1].ToString()); //make pos last num
                inPosition = false;
                position = toSearch.Count;
                return pos;
            }
            int mid = (start + stop) / 2;  //Middle of list
            if (number == toSearch[mid])  //if num is in middle
            {
                return mid.ToString();
            }
            else if (number < toSearch[mid])   //smaller thn middle
            {
                return binarySearch(toSearch, start, mid - 1, number);  //Rerun algorithm until it is middle
            }
            else  
            {
                return binarySearch(toSearch, mid + 1, stop, number);
            }
        }

        public string interpolationSearch(List<int> toSearch, int number)
        {
            int low = 0;
            int mid;
            int high = toSearch.Count - 1;
            string pos = "-1";
            inPosition = true;

            while (low < high)
            {
                r.count += 1;
                mid = low + ((number - toSearch[low]) * (high - low)) / (toSearch[high] - toSearch[low]);
                if (number < toSearch[0])    //If the number is smaller than the first num in list
                {
                    pos = (toSearch[0].ToString());    //make pos the first number
                    inPosition = false;
                    position = 1;
                    return pos;
                }
                else if (number > toSearch[toSearch.Count - 1])   //if number is bigger than biggest num in list
                {
                    pos = (toSearch[toSearch.Count - 1].ToString()); //make pos last num
                    inPosition = false;
                    position = toSearch.Count;
                    return pos;
                }

                if (toSearch[mid] == number)
                {
                    pos = mid.ToString();
                    break;
                }
                else
                {
                    if (toSearch[mid] < number)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
            if (pos == "-1")
            {
                pos = nearestToValue(toSearch, number).ToString();
                inPosition = false;
            }
            return pos;
        }

        public int nearestToValue(List<int> toSearch, int number)
        {
            int closest = toSearch.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
            position = toSearch.IndexOf(closest);   //Find the position of num in list
            return closest;
        }
    }
}
