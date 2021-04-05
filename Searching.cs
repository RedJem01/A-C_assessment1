using System;

public class searching
{
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

    Roads r = new Roads();
    public string search(List<int> toSearch)
    {
        Console.WriteLine("Please input a number.");
        string num = Console.ReadLine();
        int number = int.Parse(num);
        int start = 0;
        int stop = toSearch.Count;
        r.count = 0;
        string ret = binarySearch(toSearch, start, stop, number);
        Console.WriteLine($"This binary search took {r.count} steps");
        return ret;

    }

    public string binarySearch(List<int> toSearch, int start, int stop, int number)
    {
        r.count += 1;
        inPosition = true;
        position = 0;
        if (start > stop)
        {
            int nearest = nearestToValue(toSearch, number);
            inPosition = false;
            return nearest.ToString();
        }
        if (number < toSearch[0])
        {
            string pos = (toSearch[0].ToString());
            inPosition = false;
            position = 1;
            return pos;
        }
        else if (number > toSearch[toSearch.Count - 1])
        {
            string pos = (toSearch[toSearch.Count - 1].ToString());
            inPosition = false;
            position = toSearch.Count;
            return pos;
        }
        int mid = (start + stop) / 2;
        if (number == toSearch[mid])
        {
            return mid.ToString();
        }
        else if (number < toSearch[mid])
        {
            return binarySearch(toSearch, start, mid - 1, number);
        }
        else
        {
            return binarySearch(toSearch, mid + 1, stop, number);
        }
    }

    public int nearestToValue(List<int> toSearch, int number)
    {
        int closest = toSearch.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
        position = toSearch.IndexOf(closest);
        return closest;
    }
}
