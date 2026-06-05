

string data = "Tim,Sue,Bob,Jane";
List<string> firstNames = data.Split(',').ToList();

foreach (var firstName in firstNames) // var will automatically assign a string in this case (it is not variable)
{
    Console.WriteLine(firstName);
}