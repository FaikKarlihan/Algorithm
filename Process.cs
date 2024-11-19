class Process:GetData
{
    public void ProcessData()
    {
        Console.Clear();
        string[] parts = data.Split(',');

        int.TryParse(parts[1].Trim(), out int number);
        string str = parts[0].Trim();
        string word;
        if (number < str.Length)
        {
            word = str.Remove(number, 1);
        }
        else
        {
            word = str;
            Console.WriteLine("Index not found");
        }
        
        Console.WriteLine(word+ ", " + number);
    }
}