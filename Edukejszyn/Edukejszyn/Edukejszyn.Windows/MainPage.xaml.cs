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
            new Pytania(){Pytanie = "Pytanie 1", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4"},
            new Pytania(){Pytanie = "Pytanie 2", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4"},
            new Pytania(){Pytanie = "Pytanie 3", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4"},
            new Pytania(){Pytanie = "Pytanie 4", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4"},
            new Pytania(){Pytanie = "Pytanie 5", Odpowiedz1 = "Odpowiedz1 ", Odpowiedz2 = "Odpowiedz2", Odpowiedz3 = "Odpowiedz3", Odpowiedz4 = "Odpowiedz4"},
        };

        Logika logika = new Logika();

        public MainPage()
        {
            this.InitializeComponent();
            logika.kategoria = Logika.Kategoria.SPORT;
            SPORT.IsChecked = true;
       

        }

        private void SPORTchecked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            logika.kategoria = Logika.Kategoria.SPORT;
        }

        private void GEOchecked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            logika.kategoria = Logika.Kategoria.GEOGRAFIA;
        }

        private void INFchecked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            logika.kategoria = Logika.Kategoria.INFORMATYKA;
        }

        private void MATchecked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            logika.kategoria = Logika.Kategoria.MATEMATYKA;
        }

        private void ODPbutton1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void ODPbutton2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void ODPbutton3(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        private void ODPbutton4(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }
    }
}
