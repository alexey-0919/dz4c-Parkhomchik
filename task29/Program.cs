int [] Array = new int [8];

Random rand = new Random();

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = rand.Next(1000);
    Console.WriteLine(Array[i]);
    
}