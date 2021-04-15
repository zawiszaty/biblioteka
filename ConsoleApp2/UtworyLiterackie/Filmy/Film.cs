using System;

namespace Biblioteka.UtworyLiterackie.Filmy
{
    public class Film:Utwor
    {
        private string dlugoscFilmu;
        private readonly int numerFilmu;
        private bool dostepnosc;
        
        public Film(string tytul, string imieAutora, string nazwiskoAutora, string kategoria, int rokWydania, string dlugoscFilmu) : base(tytul, imieAutora, nazwiskoAutora, kategoria, rokWydania)
        {
            this.dlugoscFilmu = dlugoscFilmu;
            numerFilmu= UnikatowyNumer++;
        }
        
        public int NumerFilmu
        {
            get => numerFilmu;
        }
        
        public string DlugoscFilmu
        {
            get => dlugoscFilmu;
            set => dlugoscFilmu = value;
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
                dostepnosc = "DOSTEPNY";
            }
            else
            {
                dostepnosc = "NIEDOSTEPNY";
            }
            Console.WriteLine(Tytul+", "+ImieAutora+", "+NazwiskoAutora+", "+Kategoria+", Dlugosc filmu: "+dlugoscFilmu+", "+RokWydania+", UNIKATOWY NUMER: "+numerFilmu+", KSIAZKA JEST: "+dostepnosc);
        }
    }
}