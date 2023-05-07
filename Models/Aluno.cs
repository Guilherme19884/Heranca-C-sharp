using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aulaHerancaDio.Models
{
    public class Aluno : Pessoa
    {
        public double nota1 { get; set; }
        public double nota2 { get; set; }
        public string curso { get; set; }

        public double ExibirMedia()
        {
            return (this.nota1 + this.nota2) / 2;
        }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {nome}, tenho {idade} anos, e sou aluno nota {ExibirMedia()} ");
        }

    }
}