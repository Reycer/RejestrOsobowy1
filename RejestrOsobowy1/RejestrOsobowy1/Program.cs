using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using System.Numerics;

namespace RejestrOsobowy
{
    class Program
    {

            

        public static List<Osoba> ListaOsob = new List<Osoba>();
    public static void ApplicationRun()

        {
            try
            {
                System.Console.Write("Podaj swój wiek:");

                Osoba osoba = new Osoba(ToolboxClass.WprowadzLiczbeZZakresu(0, 150),
                                        ToolboxClass.WprowadzTekst("Podaj imie:", false),
                                        ToolboxClass.WprowadzTekst("Podaj Nazwisko:", false),
                                        ToolboxClass.WprowadzTekst("Podaj Plec (M lub K):", false),
                                        ToolboxClass.WprowadzKod("Podaj Kod pocztowy:", false),
                                        ToolboxClass.WprowadzTekst("Podaj Miasto:", false),
                                        ToolboxClass.WprowadzTekst("Podaj Ulice:", false),
                                        ToolboxClass.WprowadzTekst("Wprowadz numer domu:", false));
                ListaOsob.Add(osoba);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }


        public static void Deserializacja()
        {

            try
            {
                string path = Path.Combine(Environment.CurrentDirectory, "mojalista.txt");
                XmlSerializer xs = new XmlSerializer(typeof(List<Osoba>));
                using (FileStream stream = File.Open(path, FileMode.Open))
                {
                    ListaOsob = (List<Osoba>)xs.Deserialize(stream);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            }


        public static void Serializacja()
        {
            try
            {
                Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\mojalista.txt");
                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Osoba>));
                xmlSer.Serialize(stream, ListaOsob);
                stream.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }




        public static void PokazListe()
        {
            foreach (var _oOsoba in ListaOsob)
                Console.WriteLine(_oOsoba);
            System.Console.WriteLine("--------------------------");
        }
        
        public static void UsunObiekt()
        {
            
            int rozmiarListy;

            rozmiarListy = ListaOsob.Count;

            while (true)
            {
                System.Console.WriteLine("Podaj ID osoby ktora chcesz usunac: \n ");
                if (int.TryParse(Console.ReadLine(), out int id) == true &&
                    id >= 1 && id <= rozmiarListy)
                {
                    ListaOsob.RemoveAt(id-1);
                    break;
                }

                Console.Write($"(Podaj wartosc z przedzialu 1-{rozmiarListy}): \n");
            }
        }

       
            static void Main(string[] args)
        {



            Program.Deserializacja();
           

              while (true)
            {
                System.Console.WriteLine("1 - Pokaz liste");
                System.Console.WriteLine("2 - Dodaj osobe");
                System.Console.WriteLine("3 - Usun osobe");
                System.Console.WriteLine("4 - Wyjdz");


                switch (Console.ReadLine())
                {
          
                    case "1":

                        if (ListaOsob.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Lista jest pusta");
                            break;
                            
                        }
                        else
                        {
                            Console.Clear();
                            PokazListe();
                            
                            break;
                        }
                    case "2":
                        Console.Clear();
                        ApplicationRun();
                       
                        break;
                    case "3":
                        if (ListaOsob.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Lista jest pusta");
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            UsunObiekt();
                            
                            break;
                        }

                    case "4":
                        Program.Serializacja();
                        System.Environment.Exit(1);
                        break;
                        

                    default:
                        Console.WriteLine("Wybierz:");
                        break;
                }

                Program.Serializacja();
            }
        }
    }
}