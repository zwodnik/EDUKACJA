using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Edukejszyn
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        List<Pytania> SPORTpyt = new List<Pytania>() { 
            new Pytania(){Pytanie = "Sport Pytanie 1", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 1},
            new Pytania(){Pytanie = "Sport Pytanie 2", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 2},
            new Pytania(){Pytanie = "Sport Pytanie 3", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 2},
            new Pytania(){Pytanie = "Sport Pytanie 4", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 3},
            new Pytania(){Pytanie = "Sport Pytanie 5", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 4},
        };

        List<Pytania> GEOpyt = new List<Pytania>() { 
            new Pytania(){Pytanie = "Geo Pytanie 1", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 1},
            new Pytania(){Pytanie = "Geo Pytanie 2", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 2},
            new Pytania(){Pytanie = "Geo Pytanie 3", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 2},
            new Pytania(){Pytanie = "Geo Pytanie 4", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 3},
            new Pytania(){Pytanie = "Geo Pytanie 5", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 4},
        };

        List<Pytania> INFpyt = new List<Pytania>() { 
            new Pytania(){Pytanie = "Inf Pytanie 1", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 1},
            new Pytania(){Pytanie = "Inf Pytanie 2", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 2},
            new Pytania(){Pytanie = "Inf Pytanie 3", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 2},
            new Pytania(){Pytanie = "Inf Pytanie 4", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 3},
            new Pytania(){Pytanie = "Inf Pytanie 5", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 4},
        };

        List<Pytania> MATpyt = new List<Pytania>() { 
            new Pytania(){Pytanie = "Mat Pytanie 1", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 1},
            new Pytania(){Pytanie = "Mat Pytanie 2", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 2},
            new Pytania(){Pytanie = "Mat Pytanie 3", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 2},
            new Pytania(){Pytanie = "Mat Pytanie 4", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 3},
            new Pytania(){Pytanie = "Mat Pytanie 5", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4", Poprawna = 4},
        };

        Logika logika = new Logika();

        public MainPage()
        {
            this.InitializeComponent();
            logika.kategoria = Logika.Kategoria.SPORT;
            OdswiezPytanie();
            SPORT.IsChecked = true;
            logika.Losowanie();


        }

        private void SPORTchecked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            logika.kategoria = Logika.Kategoria.SPORT;
            OdswiezPytanie();
        }

        private void GEOchecked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            logika.kategoria = Logika.Kategoria.GEOGRAFIA;
            OdswiezPytanie();
        }

        private void INFchecked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            logika.kategoria = Logika.Kategoria.INFORMATYKA;
            OdswiezPytanie();
        }

        private void MATchecked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            logika.kategoria = Logika.Kategoria.MATEMATYKA;
            OdswiezPytanie();
        }

        private void ODPbutton1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // TODO: Add event handler implementation here.
            if (logika.index < SPORTpyt.Count)
            {
                if (logika.kategoria == Logika.Kategoria.SPORT && SPORTpyt[logika.randomik[logika.index]].Poprawna == 1) logika.punkty++;
                if (logika.kategoria == Logika.Kategoria.GEOGRAFIA && GEOpyt[logika.randomik[logika.index]].Poprawna == 1) logika.punkty++;
                if (logika.kategoria == Logika.Kategoria.INFORMATYKA && INFpyt[logika.randomik[logika.index]].Poprawna == 1) logika.punkty++;
                if (logika.kategoria == Logika.Kategoria.MATEMATYKA && MATpyt[logika.randomik[logika.index]].Poprawna == 1) logika.punkty++;
            }
            if (logika.index < SPORTpyt.Count) logika.index++;
            OdswiezPytanie();
        }

        private void ODPbutton2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // TODO: Add event handler implementation here.
            if (logika.index < SPORTpyt.Count)
            {
                if (logika.kategoria == Logika.Kategoria.SPORT && SPORTpyt[logika.randomik[logika.index]].Poprawna == 2) logika.punkty++;
                if (logika.kategoria == Logika.Kategoria.GEOGRAFIA && GEOpyt[logika.randomik[logika.index]].Poprawna == 2) logika.punkty++;
                if (logika.kategoria == Logika.Kategoria.INFORMATYKA && INFpyt[logika.randomik[logika.index]].Poprawna == 2) logika.punkty++;
                if (logika.kategoria == Logika.Kategoria.MATEMATYKA && MATpyt[logika.randomik[logika.index]].Poprawna == 2) logika.punkty++;
            }
            if (logika.index < SPORTpyt.Count) logika.index++;
            OdswiezPytanie();
        }

        private void ODPbutton3(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // TODO: Add event handler implementation here.
            if (logika.index < SPORTpyt.Count)
            {
                if (logika.kategoria == Logika.Kategoria.SPORT && SPORTpyt[logika.randomik[logika.index]].Poprawna == 3) logika.punkty++;
                if (logika.kategoria == Logika.Kategoria.GEOGRAFIA && GEOpyt[logika.randomik[logika.index]].Poprawna == 3) logika.punkty++;
                if (logika.kategoria == Logika.Kategoria.INFORMATYKA && INFpyt[logika.randomik[logika.index]].Poprawna == 3) logika.punkty++;
                if (logika.kategoria == Logika.Kategoria.MATEMATYKA && MATpyt[logika.randomik[logika.index]].Poprawna == 3) logika.punkty++;
            }
            if (logika.index < SPORTpyt.Count) logika.index++;
            OdswiezPytanie();
        }

        private void ODPbutton4(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // TODO: Add event handler implementation here.

            if (logika.index < SPORTpyt.Count)
            {
                if (logika.kategoria == Logika.Kategoria.SPORT && SPORTpyt[logika.randomik[logika.index]].Poprawna == 4) logika.punkty++;
                if (logika.kategoria == Logika.Kategoria.GEOGRAFIA && GEOpyt[logika.randomik[logika.index]].Poprawna == 4) logika.punkty++;
                if (logika.kategoria == Logika.Kategoria.INFORMATYKA && INFpyt[logika.randomik[logika.index]].Poprawna == 4) logika.punkty++;
                if (logika.kategoria == Logika.Kategoria.MATEMATYKA && MATpyt[logika.randomik[logika.index]].Poprawna == 4) logika.punkty++;
            }
            else
            {
                Restarcik();
            }
            if (logika.index < SPORTpyt.Count) logika.index++;

            OdswiezPytanie();
        }

        public void OdswiezPytanie()
        {
            if (logika.index < SPORTpyt.Count)
            {
                if (logika.kategoria == Logika.Kategoria.SPORT)
                {
                    PytanieBlock.Text = SPORTpyt[logika.randomik[logika.index]].Pytanie + "   " + (logika.index + 1).ToString() + "/5";
                    ODP1.Content = SPORTpyt[logika.randomik[logika.index]].Odpowiedz1;
                    ODP2.Content = SPORTpyt[logika.randomik[logika.index]].Odpowiedz2;
                    ODP3.Content = SPORTpyt[logika.randomik[logika.index]].Odpowiedz3;
                    ODP4.Content = SPORTpyt[logika.randomik[logika.index]].Odpowiedz4;

                }

                if (logika.kategoria == Logika.Kategoria.GEOGRAFIA)
                {
                    PytanieBlock.Text = GEOpyt[logika.randomik[logika.index]].Pytanie + "   " + (logika.index + 1).ToString() + "/5";
                    ODP1.Content = GEOpyt[logika.randomik[logika.index]].Odpowiedz1;
                    ODP2.Content = GEOpyt[logika.randomik[logika.index]].Odpowiedz2;
                    ODP3.Content = GEOpyt[logika.randomik[logika.index]].Odpowiedz3;
                    ODP4.Content = GEOpyt[logika.randomik[logika.index]].Odpowiedz4;

                }

                if (logika.kategoria == Logika.Kategoria.INFORMATYKA)
                {
                    PytanieBlock.Text = INFpyt[logika.randomik[logika.index]].Pytanie + "   " + (logika.index + 1).ToString() + "/5";
                    ODP1.Content = INFpyt[logika.randomik[logika.index]].Odpowiedz1;
                    ODP2.Content = INFpyt[logika.randomik[logika.index]].Odpowiedz2;
                    ODP3.Content = INFpyt[logika.randomik[logika.index]].Odpowiedz3;
                    ODP4.Content = INFpyt[logika.randomik[logika.index]].Odpowiedz4;

                }

                if (logika.kategoria == Logika.Kategoria.MATEMATYKA)
                {
                    PytanieBlock.Text = MATpyt[logika.randomik[logika.index]].Pytanie + "   " + (logika.index + 1).ToString() + "/5";
                    ODP1.Content = MATpyt[logika.randomik[logika.index]].Odpowiedz1;
                    ODP2.Content = MATpyt[logika.randomik[logika.index]].Odpowiedz2;
                    ODP3.Content = MATpyt[logika.randomik[logika.index]].Odpowiedz3;
                    ODP4.Content = MATpyt[logika.randomik[logika.index]].Odpowiedz4;

                }

                PunktyBlock.Text = "Punkty: " + logika.punkty;
            }
            else
            {
                WynikKoncowy();
            }
        }

        private void WynikKoncowy()
        {
            ODP1.Visibility = Visibility.Collapsed;
            ODP2.Visibility = Visibility.Collapsed;
            ODP3.Visibility = Visibility.Collapsed;
            ODP4.Content = "Restart";
            PunktyBlock.Visibility = Visibility.Collapsed;
            SPORT.Visibility = Visibility.Collapsed;
            GEOGRAFIA.Visibility = Visibility.Collapsed;
            INFORMATYKA.Visibility = Visibility.Collapsed;
            MATEMATYKA.Visibility = Visibility.Collapsed;
            PytanieBlock.Text = "Ilość uzyskanych punktów: " + logika.punkty + "/5";
        }

        private void Restarcik()
        {
            logika.index = -1;
            logika.punkty = 0;
            ODP1.Visibility = Visibility.Visible;
            ODP2.Visibility = Visibility.Visible;
            ODP3.Visibility = Visibility.Visible;

            PunktyBlock.Visibility = Visibility.Visible;
            SPORT.Visibility = Visibility.Visible;
            GEOGRAFIA.Visibility = Visibility.Visible;
            INFORMATYKA.Visibility = Visibility.Visible;
            MATEMATYKA.Visibility = Visibility.Visible;

        }
    }
}
