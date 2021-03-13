using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RejestrOsobowy
{
    public class Osoba : IAssert
    {
        public const string UNDEFINED_STRING = "[Niezdefiniowano]";

        private int m_iWiek;
        private string m_sImie;
        private string m_sNazwisko;
        private string m_sPlec;
        private string m_sKod;
        private string m_sMiasto;
        private string m_sUlica;
        private string m_sDom;

        public int Wiek
        {
            get => m_iWiek;
            set
            {
                if (value < 0 || value > 150)
                    throw new Exception("Pole <Wiek> musi zawierac sie w zakresie od 0 do 150");

                m_iWiek = value;
            }
        }

        public string Imie
        {
            get => m_sImie;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Imie> nie moze byc puste!");
                

                m_sImie = value;
            }
        }

        public string Plec
        {
            get => m_sPlec;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Plec> nie moze byc puste!");
                m_sPlec = value;

            }
        }

        public string Nazwisko
        {
            get => m_sNazwisko;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Nazwisko> nie moze byc puste!");

                m_sNazwisko = value;
            }
        }

        public string Kod
        {
            get => m_sKod;
            set
            {
                   if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Kod> nie moze byc puste!");

                m_sKod = value;

            }
        }

        public string Miasto
        {
            get => m_sMiasto;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Miasto> nie moze byc puste!");


                m_sMiasto = value;
            }
        }

        public string Ulica
        {
            get => m_sUlica;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Ulica> nie moze byc puste!");


                m_sUlica = value;
            }
        }

        public string Dom
        {
            get => m_sDom;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Pole <Dom> nie moze byc puste!");


                m_sDom = value;
            }
        }



        public Osoba()
        {
            m_iWiek = -1;
            m_sImie = UNDEFINED_STRING;
            m_sNazwisko = UNDEFINED_STRING;
            m_sPlec = UNDEFINED_STRING;
            m_sKod = UNDEFINED_STRING;
            m_sMiasto = UNDEFINED_STRING;
            m_sUlica = UNDEFINED_STRING;
            m_sDom = UNDEFINED_STRING;
        }
        public Osoba( int Wiek, string Imie, string Nazwisko, string Plec, string Kod, string Miasto, string Ulica, string Dom) : this()
        {
            this.Wiek = Wiek;
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Plec = Plec;
            this.Kod = Kod;
            this.Miasto = Miasto;
            this.Ulica = Ulica;
            this.Dom = Dom;

        }

        public override string ToString()
        {
            return $" Imie:{Imie} \n Nazwisko:{Nazwisko} \n Wiek:{Wiek} \n Plec:{Plec} \n Kod Pocztowy:{Kod} \n Miasto:{Miasto} \n Ulica:{Ulica} \n Dom:{Dom} \n ......................"  ;
        }

        public void AssertObject()
        {
            if (Wiek == -1)
                throw new Exception("Nie zainicjalizowano pola <Wiek>!");

            if (Imie == UNDEFINED_STRING)
                throw new Exception("Nie zainicjalizowano pola <Imie>!");

            if (Nazwisko == UNDEFINED_STRING)
                throw new Exception("Nie zainicjalizowano pola <Nazwisko>!");

            if (Plec == UNDEFINED_STRING)
                throw new Exception("Nie zainicjalizowano pola <Plec>!");
            
            if (Kod == UNDEFINED_STRING)
                throw new Exception("Nie zainicjalizowano pola <Kod>!");

            if (Miasto == UNDEFINED_STRING)
                throw new Exception("Nie zainicjalizowano pola <Miasto>!");

            if (Ulica == UNDEFINED_STRING)
                throw new Exception("Nie zainicjalizowano pola <Ulica>!");

            if (Dom == UNDEFINED_STRING)
                throw new Exception("Nie zainicjalizowano pola <Dom>!");

        }

    }
}
