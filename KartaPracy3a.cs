//Zad 1
/*
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write("*-|");
}*/

// TAbliczka mnożenia
/*
for (int i = 1; i < 11; i++)
{
	for (int j = 1; j < 11; j++)
	{
		Console.Write(i * j + "\t");
	}
	Console.WriteLine();
}*/


// Zadania - PRE - Narusyj poniższe kształty
/*
n - parametr

*
**
***

***
**
*
  *
 **
***

***
 **
  *

*/

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < i+1; j++)
	{
		Console.Write("*");
	}
	Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - i - 1; j++)
    {
        Console.Write(" ");
    }
    for (int k = n - i - 1; k < n; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
