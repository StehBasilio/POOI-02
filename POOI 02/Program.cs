using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POOI_02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Aluno jubscreudo = new Aluno();

			Console.WriteLine("Nome do aluno");
			jubscreudo.SetNome(Console.ReadLine());

			Console.WriteLine("Cpf do aluno");
			jubscreudo.SetCPf(Console.ReadLine());

			Console.WriteLine("RA do aluno");
			jubscreudo.SetRa(int.Parse(Console.ReadLine()));

			Console.WriteLine("Celular do aluno");
			jubscreudo.SetCelular(Console.ReadLine());

			Console.WriteLine("\nNome: " + jubscreudo.GetNome() + "\nCpf: " + jubscreudo.GetCpf() + "\nRA: " + jubscreudo.GetRa() + "\nCelular: " + jubscreudo.GetCelular());

			Console.ReadKey();
		}
	}
}
