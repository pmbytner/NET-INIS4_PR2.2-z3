using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_INIS4_PR2._2_z3
{
    class Osoba
    {
        static uint następneID = 0;
        string
            imię,
            nazwisko
            ;

        public string Imię { get => imię; set => imię = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string ImięNazwisko { get => $"{imię} {nazwisko}"; }
        public uint Wiek { get; set; } = 0;
        public uint ID { get; } = następneID++;
    }
    class Dane
    {
        public Osoba[] Osoby { get; set; } = {
            new Osoba() {Imię="Adam",Nazwisko="Wiśniewski",Wiek=30},
            new Osoba() {Imię="Marian",Nazwisko="Dąbrowski",Wiek=29},
            new Osoba() {Imię="Julia",Nazwisko="Jabłońska",Wiek=15},
            new Osoba() {Imię="Sylwia",Nazwisko="Sosnowska",Wiek=25},
        };
        public Dictionary<uint, string> KolorySłownik { get; set; }
            = new Dictionary<uint, string>()
            {
                [0] = "Czerwony",
                [60] = "Żółty",
                [120] = "Zielony",
                [180] = "Turkusowy",
                [240] = "Niebieski",
                [300] = "Fioletowy"
            };
        
        public IEnumerable<string> KoloryLista { get; set; }
            = new LinkedList<string>(new string[]{
                "Czerwony",
                "Żółty",
                "Zielony",
                "Morski",
                "Niebieski",
                "Fioletowy"
            });
    }
}
