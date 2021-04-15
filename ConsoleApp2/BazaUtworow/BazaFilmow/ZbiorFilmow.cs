using System;
using System.Collections.Generic;
using Biblioteka.UtworyLiterackie.Filmy;

namespace Biblioteka.BazaUtworow.BazaFilmow
{
    public class ZbiorFilmow
    {
        private List<Film> listaFilmow;

        public ZbiorFilmow()
        {
            listaFilmow = new List<Film>();
        }

        public void DodajFilm(Film film)
        {
            listaFilmow.Add(film);
        }

        public void UsunKFilm()
        {
            
        }

        public void PokazWszystkieFilmy()
        {
            foreach (Film film in listaFilmow)
            {
                film.ToString();
            }
        }
        public void SzukaniePoNazwiskuAutora()
        {
            string danaDoWyszukania;
            Console.Write("Wpisz nazwisko autora: ");
            danaDoWyszukania = Console.ReadLine();
            danaDoWyszukania = danaDoWyszukania.ToUpper();
            foreach (Film film in listaFilmow)
            {
                if (film.NazwiskoAutora.Equals(danaDoWyszukania))
                {
                    film.ToString();
                }
            }
        }
        public void SzukaniePoTytule()
        {
            string danaDoWyszukania;
            Console.Write("Wpisz tytul: ");
            danaDoWyszukania = Console.ReadLine();
            danaDoWyszukania = danaDoWyszukania.ToUpper();
            foreach (Film film in listaFilmow)
            {
                if (film.Tytul.Equals(danaDoWyszukania))
                {
                    film.ToString();
                }
            }
        }
        public void SzukaniePoGatunku()
        {
            string danaDoWyszukania;
            Console.Write("Wpisz nazwe gatunku: ");
            danaDoWyszukania = Console.ReadLine();
            danaDoWyszukania = danaDoWyszukania.ToUpper();
            foreach (Film film in listaFilmow)
            {
                if (film.Kategoria.Equals(danaDoWyszukania))
                {
                    film.ToString();
                }
            }
        }
        
        public void WypozyczFilm()
        {
            Console.WriteLine("Wpisz dane osoby ktorej chcesz wypozyczyc ksiazke: ");
            Console.Write("Imie: ");
            String imie = Console.ReadLine();
            Console.Write("Nazwisko: ");
            String nazwisko = Console.ReadLine();
            
            Console.WriteLine("Wpisz numer filmu jaki chcesz wypozyczyc: ");
            int numerKsiazkiDoWypozyczenia = Convert.ToInt32(Console.ReadLine());
            bool czyKsiazkaOTakimNumerzeIstnieje = false;

            foreach (var film in listaFilmow)
            {
                if (film.NumerFilmu.Equals(numerKsiazkiDoWypozyczenia))
                {
                    czyKsiazkaOTakimNumerzeIstnieje = true;
                    if (film.Dostepnosc == false)
                    {
                        Console.WriteLine("Ksiazka jest juz wypozyczona");
                    }
                    else
                    {
                        film.Dostepnosc = false;
                        Console.WriteLine("Ksiazka o numerze: "+numerKsiazkiDoWypozyczenia+" zostala wypozyczona.");
                    }
                }
            }
            if(czyKsiazkaOTakimNumerzeIstnieje==false)
            {
                Console.WriteLine("Ksiazka nie zostala wypozyczona, brak takiego numeru ksiazki.");   
            }
        }

        public void ZwrocFilm()
        {
            
        }
        
        public void usunFilm()
        {
            int numerDoUsuniecia;
            Console.Write("Wpisz numer do usuniecia: ");
            numerDoUsuniecia = Convert.ToInt32(Console.ReadLine());
            foreach (Film film in listaFilmow)
            {
                if (film.NumerFilmu.Equals(numerDoUsuniecia))
                {
                    listaFilmow.Remove(film);
                    break;
                }
            }
        }
    }
}