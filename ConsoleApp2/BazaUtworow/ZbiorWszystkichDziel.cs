using System;
using System.Collections.Generic;
using Biblioteka.UtworyLiterackie;
using Biblioteka.UtworyLiterackie.Ksiazka;

namespace Biblioteka.BazaUtworow
{
    public class ZbiorWszystkichDziel
    {
        private List<Utwor> listaUtworow;
        
        public ZbiorWszystkichDziel()
        {
            listaUtworow = new List<Utwor>();
        }
        
        public void DodajUtwor(Utwor utwor)
        {
            listaUtworow.Add(utwor);
        }

        public void UsunKsiazke()
        {
            
        }

        public void PokazWszystkieKsiazki()
        {
            foreach (Utwor utwor in listaUtworow)
            {
                utwor.ToString();
            }
        }
        public void SzukaniePoNazwiskuAutora()
        {
            string danaDoWyszukania;
            Console.Write("Wpisz nazwisko autora: ");
            danaDoWyszukania = Console.ReadLine();
            danaDoWyszukania = danaDoWyszukania.ToUpper();
            foreach (Utwor utwor in listaUtworow)
            {
                if (utwor.NazwiskoAutora.Equals(danaDoWyszukania))
                {
                    utwor.ToString();
                }
            }
        }
        public void SzukaniePoTytule()
        {
            string danaDoWyszukania;
            Console.Write("Wpisz tytul: ");
            danaDoWyszukania = Console.ReadLine();
            danaDoWyszukania = danaDoWyszukania.ToUpper();
            foreach (Utwor utwor in listaUtworow)
            {
                if (utwor.Tytul.Equals(danaDoWyszukania))
                {
                    utwor.ToString();
                }
            }
        }
        public void SzukaniePoGatunku()
        {
            string danaDoWyszukania;
            Console.Write("Wpisz nazwe gatunku: ");
            danaDoWyszukania = Console.ReadLine();
            danaDoWyszukania = danaDoWyszukania.ToUpper();
            foreach (Utwor utwor in listaUtworow)
            {
                if (utwor.Kategoria.Equals(danaDoWyszukania))
                {
                    utwor.ToString();
                }
            }
        }
    }
}