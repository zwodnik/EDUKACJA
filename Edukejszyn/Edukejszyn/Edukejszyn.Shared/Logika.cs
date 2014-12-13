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

        public Logika()
        {
        }

        
    }
}
