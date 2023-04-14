using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace POOI_02
{
	internal class Pessoa
	{
		string nome;
		int idade;
		string endereco;
		string celular;

		public void Receber(string nome, int idade, string endereco, string celular)
		{
			this.nome = nome;
			this.idade = idade;
			this.endereco = endereco;
			this.celular = celular;
		}

		public string Mostrar()
		{
			string texto = "\nNome:" + this.nome + "\nIdade: " + this.idade + "\nEndereço: " + this.endereco + 
				"\nCelular: " + this.celular;

			return texto;
		}
	}
}
