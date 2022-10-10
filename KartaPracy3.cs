// Zad 1
/*
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.WriteLine(Math.Pow(i, 3) + 3);
}
*/

// Zad 2
/*
for (int i = 105; i < 1000; i = i + 15)
{
    Console.WriteLine(i);
}
*/

// Zad 3
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    Console.Write(n % i == 0 ? i + " " : "");
}
