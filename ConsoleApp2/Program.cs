using System;
using System.Collections.Generic;
using Biblioteka.BazaKsiazek;
using Biblioteka.BazaUtworow;
using Biblioteka.BazaUtworow.BazaFilmow;
using Biblioteka.UtworyLiterackie;
using Biblioteka.UtworyLiterackie.Filmy;
using Biblioteka.UtworyLiterackie.Ksiazka;


namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            ZbiorKsiazek zbiorKsiazek = new ZbiorKsiazek();
            ZbiorFilmow zbiorFilmow = new ZbiorFilmow();
            
            Ksiazka bk1 = new Ksiazka("TYTUL", "autor", "nazwisko", "kategoria", 2000, 156);
            Ksiazka bk2 = new Ksiazka("TYTUL", "autor", "nazwisko", "kategoria", 2000, 156);
            Ksiazka bk3 = new Ksiazka("TYTUL", "autor", "nazwisko", "kategoria", 2000, 156);
            //Film film1 = new Film("Szklana Pulapka", "autorFilm", "nazwiskoFilm", "kategoriaFilm", 2000, "02:50");
            
            // Console.WriteLine(film1.Tytul);
            // zbiorFilmow.DodajFilm(film1);
            zbiorKsiazek.DodajKsiazke(bk1);
            zbiorKsiazek.DodajKsiazke(bk2);
            zbiorKsiazek.DodajKsiazke(bk3);
            

            Console.WriteLine("Witaj w Bibliotecke gminnej w Nasielsku");
            //Console.Clear();
            int wybor = 0;
            while (wybor!=7)
            {
                menuProgramu();
                wybor = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (wybor)
                {
                    case 1 :
                        DodawanieKsiazekIFilmow(zbiorKsiazek, zbiorFilmow);
                        break;
                    case 2 :
                        UsunKsiazkeLubFilm(zbiorKsiazek, zbiorFilmow);
                        break;
                    case 3:
                        SzukajKsiazkiIFilmow(zbiorKsiazek, zbiorFilmow);
                        break;
                    case 4 :
                        WypozyczKsiazkeIFilm(zbiorKsiazek, zbiorFilmow);
                        break;
                    case 5 :
                        OddajKsiazkeLubFilm(zbiorKsiazek, zbiorFilmow);
                        break;
                    case 6 :
                        ListaKsiazekIFilmow(zbiorKsiazek, zbiorFilmow);
                        break;
                    case 7 :
                        
                        break;
                    default:
                        Console.WriteLine("Zły wybor");
                        break;
                }
            }
        }
        public static void menuProgramu()
        {
            string[] menuProgramu = { "Dodaj ksiazke/film", "Usun ksiazke/film", "Szukaj ksiazki/filmu", "Wypozycz ksiazke/film", "Oddaj ksiazke/film", "Lista ksiazek/filmow", "Wyjscie"};
            for (int i = 0; i < menuProgramu.Length; i++)
            {
                Console.WriteLine(i+1+". "+menuProgramu[i]);
            }
        }
        
        public static void DodawanieKsiazekIFilmow(ZbiorKsiazek zbiorKsiazek, ZbiorFilmow zbiorFilmow)
        {
            int wybor;
            Console.WriteLine("Dodaj:\n1. Ksiazka\n2. Film\n3. Powrot");
            wybor = Convert.ToInt32(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    DodajKsiazke(zbiorKsiazek);
                    break;
                case 2:
                    DodajFilm(zbiorFilmow);
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Zły wybor");
                    break;
            }
        }

        public static void DodajKsiazke(ZbiorKsiazek zbiorKsiazek)
        {
            Console.WriteLine("Wpisz tytul, imie i nazwisko autora, kategorie, ilosc stron, rok wydania");
            string[] menuPomocznie = { "Wpisz tytul: ", "Wpisz imie: ", "Wpisz nazwisko: ","Wpisz kategorie: "};
            string[] menuPomocznie2 = { "Wpisz ilosc stron: ", "Wpisz rok wydania: "};
            
            string[] daneKsiazki = {"","","",""};
            int[] daneKsiazkiLiczbowe = {0,0};
            string dane;
            int daneLiczbowe;
            
            for (int i = 0; i < 4; i++)
            {
                Console.Write(menuPomocznie[i]);
                dane = Console.ReadLine();
                daneKsiazki[i] = dane.ToUpper();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.Write(menuPomocznie2[i]);
                daneLiczbowe = Convert.ToInt32(Console.ReadLine());
                daneKsiazkiLiczbowe[i] = daneLiczbowe;
            }

            Console.WriteLine("Ilosc Ksiazek jaka chcesz wprowadzic: ");
            int wybor = 0;
            wybor = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < wybor; i++)
            {
                Ksiazka book = new Ksiazka(daneKsiazki[0], daneKsiazki[1], daneKsiazki[2],
                    daneKsiazki[3], daneKsiazkiLiczbowe[0], daneKsiazkiLiczbowe[1]);
                zbiorKsiazek.DodajKsiazke(book);
            }
            Console.Clear();
        }
        
        private static void DodajFilm(ZbiorFilmow zbiorFilmow)
        {
            Console.WriteLine("Wpisz tytul, imie i nazwisko autora, kategorie, dlugosc filmu, rok wydania");
            string[] menuPomocznie = { "Wpisz tytul: ", "Wpisz imie: ", "Wpisz nazwisko: ","Wpisz kategorie: ", "Wpisz długość filmu: ", "Wpisz rok wydania: "};

            string[] daneFilmu = {"","","","",""};
            string dane;
            int rokWydania;
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write(menuPomocznie[i]);
                dane = Console.ReadLine();
                daneFilmu[i] = dane.ToUpper();
            }
            Console.Write("Wpisz rok wydania: ");
            rokWydania = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ilosc filmow jaka chcesz wprowadzic: ");
            int wybor = 0;
            wybor = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < wybor; i++)
            {
                Film film = new Film(daneFilmu[0], daneFilmu[1], daneFilmu[2],
                    daneFilmu[3], rokWydania, daneFilmu[4]);
                zbiorFilmow.DodajFilm(film);
            }
            Console.Clear();
        }

        private static void UsunKsiazkeLubFilm(ZbiorKsiazek zbiorKsiazek, ZbiorFilmow zbiorFilmow)
        {
            int wybor = 0;
            while (wybor != 3)
            {
                Console.WriteLine("1. Usun ksiazke");
                Console.WriteLine("2. Usun film");
                Console.WriteLine("3. Powrot");
                wybor = Convert.ToInt32(Console.ReadLine());
                
                switch (wybor)
                {
                    case 1:
                        zbiorKsiazek.usunKsiazke();
                        break;
                    case 2:
                        zbiorFilmow.usunFilm();
                        break;
                    default:
                        Console.WriteLine("Zly wybor");
                        break;
                }
            }
        }

        private static void SzukajKsiazkiIFilmow(ZbiorKsiazek zbiorKsiazek, ZbiorFilmow zbiorFilmow)
        {
            int wybor=0;

            while (wybor != 3)
            {
                Console.WriteLine("1. Szukaj ksiazki");
                Console.WriteLine("2. Szukaj filmu");
                Console.WriteLine("3. Powrot");
                wybor = Convert.ToInt32(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        SzukajKsiazki(zbiorKsiazek);
                        break;
                    case 2:
                        SzukajFilmu(zbiorFilmow);
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Zły wybór");
                    break;
                }
                
            }


            
        }

        private static void SzukajKsiazki(ZbiorKsiazek zbiorKsiazek)
        {
            int wybor = 0;
            while (wybor != 4)
            {
                Console.WriteLine("1. Szukanie po naziwsku autora");
                Console.WriteLine("2. Szukanie po tytule");
                Console.WriteLine("3. Szukanie po gatunku");
                Console.WriteLine("4. Powrot");
                wybor = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (wybor)
                {
                    case 1:
                        zbiorKsiazek.SzukaniePoNazwiskuAutora();
                        break;
                    case 2:
                        zbiorKsiazek.SzukaniePoTytule();
                        break;
                    case 3:
                        zbiorKsiazek.SzukaniePoGatunku();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Bledny Wybor");
                        break;
                }
            }
        }
        
        private static void SzukajFilmu(ZbiorFilmow zbiorFilmow)
        {
            int wybor = 0;
            while (wybor != 4)
            {
                Console.WriteLine("1. Szukanie po naziwsku autora");
                Console.WriteLine("2. Szukanie po tytule");
                Console.WriteLine("3. Szukanie po gatunku");
                Console.WriteLine("4. Powrot");
                wybor = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (wybor)
                {
                    case 1:
                        zbiorFilmow.SzukaniePoNazwiskuAutora();
                        break;
                    case 2:
                        zbiorFilmow.SzukaniePoTytule();
                        break;
                    case 3:
                        zbiorFilmow.SzukaniePoGatunku();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Bledny Wybor");
                        break;
                }
            }
        }
        
        private static void WypozyczKsiazkeIFilm(ZbiorKsiazek zbiorKsiazek, ZbiorFilmow zbiorFilmow)
        {
            int wybor = 0;
            while (wybor != 3)
            {
                Console.WriteLine("1. Wypozycz ksiazke");
                Console.WriteLine("2. Wypozycz film");
                Console.WriteLine("3. Powrot");
                wybor = Convert.ToInt32(Console.ReadLine());
                
                switch (wybor)
                {
                    case 1:
                        zbiorKsiazek.WypozyczKsiazke();
                        break;
                    case 2:
                        zbiorFilmow.WypozyczFilm();
                        break;
                    default:
                        Console.WriteLine("Zly wybor");
                        break;

                }
                
            }
        }

        private static void OddajKsiazkeLubFilm(ZbiorKsiazek zbiorKsiazek, ZbiorFilmow zbiorFilmow)
        {
            int wybor = 0;
            while (wybor != 3)
            {
                Console.WriteLine("1. Zwroc ksiazke");
                Console.WriteLine("2. Zwroc film");
                Console.WriteLine("3. Powrot");
                wybor = Convert.ToInt32(Console.ReadLine());
                
                switch (wybor)
                {
                    case 1:
                        zbiorKsiazek.ZwrocKsiazke();
                        break;
                    case 2:
                        zbiorFilmow.ZwrocFilm();
                        break;
                    default:
                        Console.WriteLine("Zly wybor");
                        break;
                }
            }
            
        }
        private static void ListaKsiazekIFilmow(ZbiorKsiazek zbiorKsiazek, ZbiorFilmow zbiorFilmow)
        {
            zbiorKsiazek.PokazWszystkieKsiazki();
            zbiorFilmow.PokazWszystkieFilmy();
        }
    }
}