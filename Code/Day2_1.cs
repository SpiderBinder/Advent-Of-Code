string input = File.ReadAllText("Input.txt");
string[] data = input.Split("\r\n");
int[,] moves = new int[data.Length, 2];
int points = 0;

string[] temp = new string[2];
for (int i = 0; i < data.Length; i++)
{
    temp = data[i].Split(' ');
    switch (temp[0])
    {
        case "A":
            moves[i, 0] = 1;
            break;
        case "B":
            moves[i, 0] = 2;
            break;
        case "C":
            moves[i, 0] = 3;
            break;
    }

    switch (temp[1])
    {
        case "X":
            moves[i, 1] = 1;
            break;
        case "Y":
            moves[i, 1] = 2;
            break;
        case "Z":
            moves[i, 1] = 3;
            break;
    }
}

for (int j = 0; j < moves.GetLength(0); j++)
{
    if (moves[j, 0] % 3 + 1 == moves[j, 1]) points += 6;
    else if (moves[j, 0] == moves[j, 1]) points += 3;

    points += moves[j, 1];
}

Console.WriteLine(points);
