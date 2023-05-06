using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aulaHerancaDio.Models
{
    public class Pessoa
    {
        public String nome { get; set; }
        public int idade { get; set; }

        public void Apresentar()
        {
            System.Console.WriteLine($"Meu nome é {nome}, e tenho {idade} anos!");
        }

    }
}