using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_02
{
	internal class Aluno
	{
		string nome;
		string cpf;
		int ra;
		string celular;

		public void SetNome(string nome)
		{
			this.nome = nome;
		}

		public string GetNome()
		{
			return this.nome;
		}

		public void SetCPf(string cpf)
		{
			this.cpf = cpf;
		}

		public string GetCpf()
		{
			return this.cpf;
		}

		public void SetRa(int ra)
		{
			this.ra = ra;
		}

		public int GetRa()
		{
			return this.ra;
		}

		public void SetCelular(string celular)
		{
			this.celular = celular;
		}

		public string GetCelular()
		{
			return this.celular;
		}

	}
}
