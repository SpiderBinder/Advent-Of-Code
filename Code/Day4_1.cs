// Classic input variable!
string input = File.ReadAllText("Input.txt");
string[] data = input.Split("\r\n");

// This is like the perfect mix of using multidimensional arrays to avoid multiple arrays and then doing it anyway 
int[,] array1 = new int[data.Length, 2];
int[,] array2 = new int[data.Length, 2];
string[] temp;
for (int i = 0; i < data.Length; i++)
{
    // Why is this?
    temp = data[i].Split(',', '-');
    array1[i, 0] = int.Parse(temp[0]);
    array1[i, 1] = int.Parse(temp[1]);
    array2[i, 0] = int.Parse(temp[2]);
    array2[i, 1] = int.Parse(temp[3]);
}

int num = 0;
for (int i = 0; i < data.Length; i++)
{
    // This sucks but I want to sleep so whatever
    if ((array1[i, 0] <= array2[i, 0] && array1[i, 1] >= array2[i, 1])
        || (array2[i, 0] <= array1[i, 0] && array2[i, 1] >= array1[i, 1]))
    {
        num++;
    }
}

Console.WriteLine(num);
