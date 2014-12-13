using System;
using System.Collections.Generic;
using System.Text;

namespace Edukejszyn
{
    class Logika
    {
        public enum Kategoria
        {
            SPORT,
            GEOGRAFIA,
            INFORMATYKA,
            MATEMATYKA
        }

        public Kategoria kategoria;
        public int punkty = 0;
        public int index = 0;
        public int[] randomik = new int[5];

        public Logika()
        {
        }

        public void Losowanie()
        {
              for(int i = 0; i < 5; i++)
            {
                randomik[i] = -1;
               
            }
            Random random = new Random();
            for(int i = 0; i < 5; i++)
            {
               
                randomik[i] = random.Next(0, 5);
                for (int j = 0; j < 5; j++)
                {
                    if (randomik[i] == randomik[j] && i != j)
                    {
                        i--;
                        break;
                    }
                }
            }
        }
        
    }
}
