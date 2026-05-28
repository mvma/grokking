using Grooking.Algo;

Console.WriteLine("Grokking playground...");

HashFunction hashFunction = new HashFunction();

string[] phoneBook = new string[4]{"Esther", "Ben", "Bob", "Dan"};
for(int i = 0; i < phoneBook.Length; i++)
{
    int index = hashFunction.Hash(phoneBook[i], slots:10);
    Console.WriteLine($"{phoneBook[i]} at index {index}");
}

string[] batterySize = new string[3]{"A","AA","AAA"};
for(int i = 0; i < batterySize.Length; i++)
{
    int index = hashFunction.Hash(batterySize[i], slots:10);
    Console.WriteLine($"{batterySize[i]} at index {index}");
}

string[] bookTitles = new string[3]{"Maus", "Fun Home", "Watchmen"};
for(int i = 0; i < bookTitles.Length; i++)
{
    int index = hashFunction.Hash(bookTitles[i], slots:10);
    Console.WriteLine($"{bookTitles[i]} at index {index}");
}