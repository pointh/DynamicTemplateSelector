using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    class Kniha:Tiskovina
    {
        public string Nazev { get; set; }
        public string Autor { get; set; }
        public int RokPoslednihoVydani { get; set; }

        public override string ToString() =>
            $"Kniha {Nazev}, autor {Autor}, vydavatel {Vydavatel}";
    }
}
