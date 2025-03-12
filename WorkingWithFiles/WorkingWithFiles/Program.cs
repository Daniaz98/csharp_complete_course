using WorkingWithFiles.Entities;

Console.WriteLine("Enter full file path: ");
string filePath = Console.ReadLine();

try
{
    string[] lines = File.ReadAllLines(filePath);

    string sourcePathFolder = Path.GetDirectoryName(filePath);
    string targetFolderPath = sourcePathFolder + @"\out";
    string targetFilePath = targetFolderPath + @"\summary.csv";
    
    Directory.CreateDirectory(targetFolderPath);

    using (StreamWriter sw = File.AppendText(targetFilePath))
    {
        foreach (var line in lines)
        {
            string[] fields = line.Split(',');
            string name = fields[0];    
            int price = int.Parse(fields[1]);
            int quantity = int.Parse(fields[2]);
            
            Product product = new Product(name, price, quantity);
            
            sw.WriteLine(product.Name + "," + product.TotalQ());
        }
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
    throw;
}