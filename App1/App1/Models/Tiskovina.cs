using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public abstract class Tiskovina
    {
        public int RokPrvnihoVydani { get; set; }
        public string Vydavatel { get; set; }
        public abstract override string ToString();

        public static List<Tiskovina> tiskoviny = new List<Tiskovina>()
        {
            new Kniha { Autor = "Steinbeck", Nazev = "Hrozny hněvu", RokPoslednihoVydani = 2019, Vydavatel = "Atlantis"},
            new Casopis { Nazev = "VTM", Rok = 2021, Cislo = 12, Vydavatel = "Academia"},
            new Kniha { Autor = "Kerouac", Nazev = "Na cestě", RokPoslednihoVydani = 2002, Vydavatel = "Prostor"},
            new Casopis { Nazev = "Vesmír", Rok = 2019, Cislo = 11, Vydavatel = "Academia"},
        };
    }
}
