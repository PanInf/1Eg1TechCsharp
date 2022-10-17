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
            /*
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                //Console.Write(n % i == 0 ? i + " " : "");
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            } */

            // Zad 4

            /*
            int suma = 0;
            for (int i = 10; i < 100; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine(suma);
            */

            // Zad 5
            /*
            int n = int.Parse(Console.ReadLine());
            int suma = n * (n + 1) / 2;
            int liczba;

            for (int i = 0; i < n-1; i++)
            {
                liczba = int.Parse(Console.ReadLine());
                suma = suma - liczba;
            }
            Console.WriteLine("");
            Console.WriteLine(suma);
            Console.ReadKey();*/

            //Zad 6
               /*
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int temp;
            for (int i = 0; i < n; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine(b);*/
