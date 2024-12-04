
int[] numbers1 = new int[5];
int[] numbers2 = new int[5];
int[] numbers3 = new int[5];

Random random = new Random();

for (int i = 0; i < numbers1.Length; i++)
{ 
    numbers1[i] = random.Next(0, 11);
    numbers2[i] = random.Next(0, 11);

    numbers3[i] = numbers1[i] + numbers2[i];
}

Console.WriteLine("=== Som maken van getallen uit 2 arrays ===");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Array 1 ==>    {string.Join('\t', numbers1)}");
Console.WriteLine($"Array 2 ==>    {string.Join('\t', numbers2)}");
Console.WriteLine($"Array 3 ==>    {string.Join('\t', numbers3)}");

