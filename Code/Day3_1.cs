string input = File.ReadAllText("Input.txt");
string[] data = input.Split("\r\n");

string[,] array = new string[data.Length, 2];
for (int i = 0; i < data.Length; i++)
{
    int mid = data[i].Length / 2;
    array[i, 0] = data[i].Substring(0, mid);
    array[i, 1] = data[i].Substring(mid);
}

char[] duplicate = new char[array.GetLength(0)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array[i, 0].Length; j++)
    {
        if (array[i, 1].Contains(array[i, 0][j]))
        {
            duplicate[i] = array[i, 0][j];
            break;
        }
    }
}

int num = 0;
foreach (char c in duplicate)
{
    if (Char.IsUpper(c)) num += Convert.ToInt32(c) - 38;
    else num += Convert.ToInt32(c) - 96;
}

Console.WriteLine(num);
