//Wygeneruj tablicę n losowych liczb:
//Random r = new Random()
//r.Next(pocz, kon)
//n = 10 w przedziale [1,20]

/*
1. Znajdź największą liczbę w tablicy
2. Znajdź najmniejszą liczbę w tablicy
3. Podaj ile razy występuje najwieksza liczba w tablicy
4. Podaj ile razy występuje najmniejsza liczba w tablicy
5. Podaj rozpiętość tablicy (różnica max - min)
6. Podaj sumę liczb w tablicy
7. Podaj średnią wartość liczb w tablicy
8. Których liczb jest więcej w tablicy: parzystych czy nieparzystych?
9. Ile w tablicy jest liczb pierwszych?
10. Podaj v-ce max i v-ce min liczb tablicy
*/

int n = 20;
Random random = new Random();
int[] T = new int[n];
for (int i = 0; i < T.Count(); i++)
{
    T[i] = random.Next(1,21);
}

for (int i = 0; i < T.Length; i++)
{
    Console.Write(T[i] + " ");
}
Console.WriteLine("\n");

// 1. Znajdź największą liczbę w tablicy
/*Console.WriteLine(T.Max());
int maksik = T[0];
for (int i = 1; i < T.Count(); i++)
{
    if (T[i] > maksik)
    {
        maksik = T[i];
    }
}
Console.WriteLine(maksik);*/

// 2. Znajdź najmniejszą liczbę w tablicy
/*Console.WriteLine(T.Min());
int minik = T[0];
for (int i = 0; i < T.Length; i++)
{
    if (T[i] < minik)
    {
        minik = T[i];
    }
}
Console.WriteLine(minik);*/

// 3. Podaj ile razy występuje najwieksza liczba w tablicy

/*int maksik = T[0];
int ilosc_maksik = 1;
for (int i = 1; i < T.Length; i++)
{
    if (T[i] > maksik)
    {
        maksik = T[i];
        ilosc_maksik = 1;
    }
    else if (T[i] == maksik)
    {
        ilosc_maksik++;
    }
}
Console.WriteLine(maksik + " w ilosci " + ilosc_maksik);*/

// 7. Podaj średnią liczb w tablicy
int suma = 0;
for (int i = 0; i < T.Length; i++)
{
    suma += T[i];
}
Console.WriteLine(Math.Round(suma/20d,1));

