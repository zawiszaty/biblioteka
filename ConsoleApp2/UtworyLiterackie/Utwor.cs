using System;

namespace Biblioteka.UtworyLiterackie
{
    public abstract class Utwor
    {
        private string tytul;
        private string imieAutora;
        private string nazwiskoAutora;
        private string kategoria;
        private int rokWydania;
        private static int unikatowyNumer = 50;
        public Utwor(string tytul, string imieAutora, string nazwiskoAutora, string kategoria, int rokWydania)
        {
            this.Tytul = tytul;
            this.ImieAutora = imieAutora;
            this.NazwiskoAutora = nazwiskoAutora;
            this.RokWydania = rokWydania;
            this.Kategoria = kategoria;
        }
        
        public int UnikatowyNumer
        {
            get => unikatowyNumer;
            set => unikatowyNumer = value;
        }

        public string Tytul
        {
            get => tytul;
            set => tytul = value;
        }

        public string ImieAutora
        {
            get => imieAutora;
            set => imieAutora = value;
        }

        public string NazwiskoAutora
        {
            get => nazwiskoAutora;
            set => nazwiskoAutora = value;
        }

        public string Kategoria
        {
            get => kategoria;
            set => kategoria = value;
        }

        public int RokWydania
        {
            get => rokWydania;
            set => rokWydania = value;
        }

        public virtual void ToString()
        {
            Console.WriteLine(Tytul+", "+ImieAutora+", "+NazwiskoAutora+", "+Kategoria+", "+RokWydania);
        }
    }
}