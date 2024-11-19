using System.Diagnostics;
using System.Text.RegularExpressions;

class GetData
{
    public string data{get; set;}
    public string GetTheData()
    {
        Console.Clear();
        Console.WriteLine("Please enter a word and the index of the word you want to delete, separated by commas.\nindexes start from zero.");

        while (true)
        {
            Console.Write("Input: ");data =  Console.ReadLine();

            var numberMatches = Regex.Matches(data, @"\d+");

            if (
               data.Contains(",")
            && data.Count(c => c == ',') == 1
            && data.Any(char.IsDigit)
            && data.Any(char.IsLetter)
            && numberMatches.Count == 1
            && data.Split(',')[1].Trim().All(char.IsDigit))
            {
                return data.Trim();
            }
            else
            {
                Console.WriteLine("Invalid input. Please use the format: word,number");
            }
        }

    }
}