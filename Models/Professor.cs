using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aulaHerancaDio.Models
{
    public class Professor : Pessoa
    {
        public double salario { get; set; }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {nome}, tenho {idade} anos, sou professro e ganho {salario} dollares");

        }
    }
}