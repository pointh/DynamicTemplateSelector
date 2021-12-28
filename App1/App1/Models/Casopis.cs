using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    class Casopis:Tiskovina
    {
        public string Nazev { get; set; }
        public int Rok { get; set; }
        public int Cislo { get; set; }

        public override string ToString() => 
            $"Časopis rok: {Rok}, číslo {Cislo}, vydavatel {Vydavatel}";
        
    }
}
