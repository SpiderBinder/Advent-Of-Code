string input = File.ReadAllText("Calories.txt");
string[] array = input.Split('\n');
int calorie = 0;
int max = 0;

foreach (string i in array)
{
    if (i == array[4])
    {
        if (calorie > max) max = calorie;
        calorie = 0;
        continue;
    }
    
    calorie += int.Parse(i);
}
Console.WriteLine(max);
