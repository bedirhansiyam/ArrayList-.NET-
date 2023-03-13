using System.Collections;

namespace arrayList;
class Program
{
    static void Main(string[] args)
    {
        // System.Collections namespace

        ArrayList list = new ArrayList();
        list.Add("Bedirhan");
        list.Add(22);
        list.Add(false);
        list.Add('F');

        Console.WriteLine(list[1]);   // 22
        
        foreach (var item in list)
            Console.WriteLine(item);   // Bedirhan 22 false F
        

        // AddRange
        string[] colors = {"Blue", "Yellow", "Green"};
        List<int> numbers = new List<int>(){1,6,7,12,4,3,9};

        list.AddRange(colors);
        list.AddRange(numbers);

        foreach (var item in list)
            Console.WriteLine(item);

        // Sort
        list.Sort();   // Failed. (must have elements of the same type)

        // Binary Search
        Console.WriteLine(list.BinarySearch(6));

        // Reverse
        list.Reverse();
        foreach (var item in list)
            Console.WriteLine(item);

        // Clear
        list.Clear();

    }
}
