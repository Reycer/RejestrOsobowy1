using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RejestrOsobowy
{
    public class ToolboxClass
    {
        public static int WprowadzLiczbeZZakresu(int a_iMin, int a_iMax)
        {
            while (true)
            {
                

                if (int.TryParse(Console.ReadLine(),out int _iValue) == true && 
                    _iValue >= a_iMin && _iValue <= a_iMax)
                {
                    return _iValue;
                }

                Console.Write($"(Podaj wartosc z przedzialu {a_iMin}-{a_iMax}):");
            }
        }

        public static string WprowadzTekst(string a_sText, bool a_bCanBeEmpty = true)
        {
            while (true)
            {
                Console.Write(a_sText);

                string _sValue = Console.ReadLine();

                if (string.IsNullOrEmpty(_sValue) && a_bCanBeEmpty == false)
                {
                    Console.WriteLine("Nie wpisano wartosci");
                }
                else
                    return _sValue;
            }
        }


        public static string WprowadzKod(string a_sText, bool a_bCanBeEmpty = true)
        {


            while (true)
            {
                Console.Write(a_sText);
                string _sValue = Console.ReadLine(); 

                if (string.IsNullOrEmpty(_sValue) && a_bCanBeEmpty == false)
                {
                    Console.WriteLine("Nie wpisano wartosci");
                }

                else
                    return _sValue;
            }
        }

    }


}