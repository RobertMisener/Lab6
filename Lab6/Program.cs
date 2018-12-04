using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
//     1) Create Project
//     2) The array access expressions are = p[0], p[1], [2], p[3]
//     3) Create 12 elelement array  
            string[] months = new string[12] {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            foreach (string month in months)
            {
                Console.WriteLine(month);
            }
//     4)  4 element season array
            string[] seasons = new string[4] {"Spring","Summer", "Fall","Winter"};

            foreach  (string season in seasons)
            {
                Console.WriteLine(season);
            }

//     5) array 1000 elements, random numbers
            int[] randoms = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                Random random = new Random();
                int randomInt = random.Next(0, 100);
                randoms[i] = randomInt;
            }
            foreach (int random in randoms)
            {
                Console.WriteLine(random);
            }


//     6) 
            string[] names = new string [5] { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };


            int ii = 0;
            while (ii < names.Length)
            {
                Console.WriteLine( names[ii]);
                ii++;
            }

//     7)

            int x = 0;
            while (x<5)
            {
                Console.WriteLine("{0,2}. {1}", x+1, names[x]);
                x++;
            }

//     8)
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();

        }
    }
}
