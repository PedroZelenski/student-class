using System;
using System.Collections.Generic;
using System.Text;

namespace student_class
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sala { get; set; }
       
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }

        public void Notas()
        {
            Console.WriteLine("Digite a primeira nota: ");
            Nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            Nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            Nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota: ");
            Nota4 = Convert.ToDouble(Console.ReadLine());
        }

        public void MediaFinal()
        {
            double media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            Console.WriteLine($"A MEDIA E: {media}");
        }
    }
}
