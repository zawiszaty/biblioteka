using System;

namespace Biblioteka.UtworyLiterackie.Ksiazka
{
    public class Ksiazka:Utwor
    {
        private int iloscStron;
        private bool dostepnosc;
        public int NumerKsiazki { get; }

        public Ksiazka(string tytul, string imieAutora, string nazwiskoAutora, string kategoria, int rokWydania, int iloscStron) : base(tytul, imieAutora, nazwiskoAutora, kategoria,rokWydania)
        {
            this.iloscStron = iloscStron;
            NumerKsiazki = UnikatowyNumer++;
            dostepnosc = true;
        }

        public int IloscStron
        {
            get => iloscStron;
            set => iloscStron = value;
        }
        
        public bool Dostepnosc
        {
            get => dostepnosc;
            set => dostepnosc = value;
        }

        public override void ToString()
        {
            string dostepnosc;
            if (Dostepnosc == true)
            {
                dostepnosc = "DOSTEPNA";
            }
            else
            {
                dostepnosc = "NIEDOSTEPNA";
            }
             
            Console.WriteLine(Tytul+", "+ImieAutora+", "+NazwiskoAutora+", "+Kategoria+", "+IloscStron+", "+RokWydania+", UNIKATOWY NUMER: "+NumerKsiazki+", KSIAZKA JEST: "+dostepnosc);
        }
    }
}