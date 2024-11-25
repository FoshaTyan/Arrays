using System.Text;

Console.OutputEncoding = Encoding.UTF8;

string inputFilePath = "C:\\Users\\Артём\\source\\repos\\Arrays\\input.txt";
string codedFilePath = "C:\\Users\\Артём\\source\\repos\\Arrays\\coded.txt";
string decodedFilePath = "C:\\Users\\Артём\\source\\repos\\Arrays\\decoded.txt";

Console.WriteLine("На скільки бітів зсувати вправо(m):");
int m = int.Parse(Console.ReadLine()); 

// Кодування файла
СodeFile(inputFilePath, codedFilePath, m);
Console.WriteLine("Файл закодовано і збережено у 'coded.txt'.");

// Декодування файла
DecodeFile(codedFilePath, decodedFilePath, m);
Console.WriteLine("Файл декодовано і збережено у 'decoded.txt'.");

void СodeFile(string inputFilePath, string outputFilePath, int m)
{
    string text = File.ReadAllText(inputFilePath, Encoding.UTF8);
    StringBuilder codedText = new StringBuilder();

    foreach (char c in text)
    {
        // Зсув символа на m бітів вправо
        char codedChar = (char)((c >> m) | (c << (16 - m)));
        codedText.Append(codedChar);
    }

    File.WriteAllText(outputFilePath, codedText.ToString(), Encoding.UTF8);
}

void DecodeFile(string inputFilePath, string outputFilePath, int m)
{
    string text = File.ReadAllText(inputFilePath, Encoding.UTF8);
    StringBuilder decodedText = new StringBuilder();

    foreach (char c in text)
    {
        // Зворотній зсув бітів на m позицій для відновлення
        char decodedChar = (char)((c << m) | (c >> (16 - m)));
        decodedText.Append(decodedChar);
    }

    File.WriteAllText(outputFilePath, decodedText.ToString(), Encoding.UTF8);
}