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

        List<int> indeksiki = new List<int> { 0, 1, 2, 3, 4 };

        public Logika()
        {
        }

        public void Losowanie()
        {
            indeksiki = new List<int> { 0, 1, 2, 3, 4 };

            Random random = new Random();
            for(int i = 0; i < 5; i++)
            {

                randomik[i] = indeksiki[random.Next(0, indeksiki.Count)];
                indeksiki.Remove(randomik[i]);
            }
        }
        
    }
}
