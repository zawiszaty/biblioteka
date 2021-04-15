using System;
using System.Collections.Generic;
using System.Linq;
using Biblioteka.UtworyLiterackie.Ksiazka;

namespace Biblioteka.BazaKsiazek
{
    public class ZbiorKsiazek
    {
        private List<Ksiazka> listaKsiazek;
        
        public ZbiorKsiazek()
        {
            listaKsiazek = new List<Ksiazka>();
        }

        public void DodajKsiazke(Ksiazka ksiazka)
        {
            listaKsiazek.Add(ksiazka);
        }

        public void UsunKsiazke()
        {
            
        }

        public void PokazWszystkieKsiazki()
        {
            foreach (Ksiazka ksiazka in listaKsiazek)
            {
                ksiazka.ToString();
            }
        }
        public void SzukaniePoNazwiskuAutora()
        {
            string danaDoWyszukania;
            Console.Write("Wpisz nazwisko autora: ");
            danaDoWyszukania = Console.ReadLine();
            danaDoWyszukania = danaDoWyszukania.ToUpper();
            foreach (Ksiazka ksiazka in listaKsiazek)
            {
                if (ksiazka.NazwiskoAutora.Equals(danaDoWyszukania))
                {
                    ksiazka.ToString();
                }
            }
        }
        
        public void SzukaniePoTytule()
        {
            string danaDoWyszukania;
            Console.Write("Wpisz tytul: ");
            danaDoWyszukania = Console.ReadLine();
            danaDoWyszukania = danaDoWyszukania.ToUpper();
            foreach (Ksiazka ksiazka in listaKsiazek)
            {
                if (ksiazka.Tytul.Equals(danaDoWyszukania))
                {
                    ksiazka.ToString();
                }
            }
        }
        
        public void SzukaniePoGatunku()
        {
            string danaDoWyszukania;
            Console.Write("Wpisz nazwe gatunku: ");
            danaDoWyszukania = Console.ReadLine();
            danaDoWyszukania = danaDoWyszukania.ToUpper();
            foreach (Ksiazka ksiazka in listaKsiazek)
            {
                if (ksiazka.Kategoria.Equals(danaDoWyszukania))
                {
                    ksiazka.ToString();
                }
            }
        }
        
        public void usunKsiazke()
        {
            int numerDoUsuniecia;
            Console.Write("Wpisz numer do usuniecia: ");
            numerDoUsuniecia = Convert.ToInt32(Console.ReadLine());
            foreach (Ksiazka ksiazka in listaKsiazek)
            {
                if (ksiazka.NumerKsiazki.Equals(numerDoUsuniecia))
                {
                    listaKsiazek.Remove(ksiazka);
                    break;
                }
            }
        }

        public void WypozyczKsiazke()
        {
            Console.WriteLine("Wpisz dane osoby ktorej chcesz wypozyczyc ksiazke: ");
            Console.Write("Imie: ");
            String imie = Console.ReadLine();
            Console.Write("Nazwisko: ");
            String nazwisko = Console.ReadLine();
            
            Console.WriteLine("Wpisz numer ksiazki jaki chcesz wypozyczyc: ");
            int numerKsiazkiDoWypozyczenia = Convert.ToInt32(Console.ReadLine());
            bool czyKsiazkaOTakimNumerzeIstnieje = false;

            foreach (var ksiazka in listaKsiazek)
            {
                if (ksiazka.NumerKsiazki.Equals(numerKsiazkiDoWypozyczenia))
                {
                    czyKsiazkaOTakimNumerzeIstnieje = true;
                    if (ksiazka.Dostepnosc == false)
                    {
                        Console.WriteLine("Ksiazka jest juz wypozyczona");
                    }
                    else
                    {
                        ksiazka.Dostepnosc = false;
                        Console.WriteLine("Ksiazka o numerze: "+numerKsiazkiDoWypozyczenia+" zostala wypozyczona.");
                    }
                }
            }
            if(czyKsiazkaOTakimNumerzeIstnieje==false)
            {
              Console.WriteLine("Ksiazka nie zostala wypozyczona, brak takiego numeru ksiazki.");   
            }
        }
        
        public void ZwrocKsiazke()
        {
            Console.WriteLine("Wpisz numer ksiazki jaki chcesz zwrocic: ");
            int numerKsiazkiDoWypozyczenia = Convert.ToInt32(Console.ReadLine());
            bool czyKsiazkaOTakimNumerzeIstnieje = false;

            foreach (var ksiazka in listaKsiazek)
            {
                if (ksiazka.NumerKsiazki.Equals(numerKsiazkiDoWypozyczenia))
                {
                    czyKsiazkaOTakimNumerzeIstnieje = true;
                    if (ksiazka.Dostepnosc == false)
                    {
                        ksiazka.Dostepnosc = true;
                        Console.WriteLine("Ksiazka zostala zwrocona");
                    }
                    else
                    {
                        Console.WriteLine("Ksiazka o numerze: "+numerKsiazkiDoWypozyczenia+" nie zostala wypozyczona");
                    }
                }
            }
            if(czyKsiazkaOTakimNumerzeIstnieje==false)
            {
                Console.WriteLine("Brak takiego numeru ksiazki.");   
            }
        }
    }
}