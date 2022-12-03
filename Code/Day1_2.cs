class Program
{
    public static void Main(string[] args)
    {
        string input = File.ReadAllText("Calories.txt");
        string[] array = input.Split('\n');
        int calorie = 0;
        List<int> calories = new List<int>();

        foreach (string i in array)
        {
            if (i == array[4])
            {
                calories.Add(calorie);
                calorie = 0;
                continue;
            }
    
            calorie += int.Parse(i);
        }

        calories.Sort();
        Console.WriteLine($"{calories[calories.Count - 1]}\n{calories[calories.Count - 2]}\n{calories[calories.Count - 3]}");
    }
    
    private static int[] ArraySort(int[] array, int l, int r)
    {
        if (l < r)
        {
            int m = l + (r - l) / 2;
            ArraySort(array, l, m);
            ArraySort(array, m + 1, r);
            
            ArrayMerge(array, l, m, r);
        }

        return array;
    }

    private static void ArrayMerge(int[] array, int l, int m, int r)
    {
        int leftLength = m - l + 1;
        int rightLength = r - m;
        int[] leftTemp = new int[leftLength];
        int[] rightTemp = new int[rightLength];

        for (int a = 0; a < leftLength; a++) leftTemp[a] = array[l + a];
        for (int a = 0; a < rightLength; a++) rightTemp[a] = array[m + 1 + a];

        int i = 0;
        int j = 0;
        int k = l;
        
        while (i < leftLength && j < rightLength)
        {
            if (leftTemp[i] <= rightTemp[j]) array[k++] = leftTemp[i++];
            else array[k++] = rightTemp[j++];
        }
        while (i < leftLength) array[k++] = leftTemp[i++];
        while (j < rightLength) array[k++] = rightTemp[j++];
    }
}
