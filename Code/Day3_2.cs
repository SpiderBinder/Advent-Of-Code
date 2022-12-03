string input = File.ReadAllText("Input.txt");
string[] data = input.Split("\r\n");

string[,] array = new string[data.Length / 3, 3];

int x = 0;
for (int i = 0; i < data.Length; i++)
{
    if (x == 3) x = 0;
    array[i / 3, x] = data[i];
    x++;
}

int num = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array[i, 0].Length; j++)
    {
        if (array[i, 1].Contains(array[i, 0][j]) && array[i, 2].Contains(array[i, 0][j]))
        {
            if (Char.IsUpper(array[i, 0][j])) num += Convert.ToInt32(array[i, 0][j]) - 38;
            else num += Convert.ToInt32(array[i, 0][j]) - 96;
            break;
        }
    }
}

Console.WriteLine(num);
