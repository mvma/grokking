using Grooking.Algo;

Console.WriteLine("Grokking playground...");
HashFunction hashingFunction = new HashFunction();
int hashValue = hashingFunction.Hash("bag", slots:10);
Console.WriteLine($"The value after hashing is: {hashValue}");