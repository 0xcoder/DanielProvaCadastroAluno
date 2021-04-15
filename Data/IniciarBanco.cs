using CadastroAluno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroAluno.Data
{
    public class IniciarBanco
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();

            if (context.aluno.Any())
            {
                return;
            }

            var aluno = new Aluno[]
            {
                new Aluno 
                {
                Nome = "Joao",
                Telefone ="1699400554",
                RG="456114-7",
                Endereco ="Rua: Julia Nº22",
                DtaNasci= "19/04/2021"
                },
                new Aluno 
                {
                Nome = "Marcos",
                Telefone ="1694564564",
                RG="2132314-7",
                Endereco ="Rua: Pereira Nº22",
                DtaNasci= "19/09/2002"
                },
                new Aluno 
                {
                Nome = "Lucas",
                Telefone ="1612312154",
                RG="1111111-7",
                Endereco ="Rua: Joanaez Nº22",
                DtaNasci= "20/05/2002"
                },
                new Aluno 
                {
                Nome = "Maria",
                Telefone ="169999999",
                RG="9123999-7",
                Endereco ="Rua: Dona Nº22",
                DtaNasci= "30/08/2002"
                },
                new Aluno 
                {
                Nome = "Mario",
                Telefone ="16998844",
                RG="987899-7",
                Endereco ="Rua: Dona Nº22",
                DtaNasci= "19/11/2002"
                },
                new Aluno 
                {
                Nome = "Gabriel",
                Telefone ="16772514",
                RG="991219-7",
                Endereco ="Rua: Dona Nº22",
                DtaNasci= "03/12/2002"
                },
                new Aluno 
                {
                Nome = "Tete",
                Telefone ="16944844",
                RG="162991219-7",
                Endereco ="Rua: Luzitana Nº22",
                DtaNasci= "19/06/2002"
                },
                new Aluno 
                {
                Nome = "Yves",
                Telefone ="16911544",
                RG="16991219-7",
                Endereco ="Rua: Mariana Condino Nº22",
                DtaNasci= "20/07/2002"
                },
                new Aluno 
                {
                Nome = "Estevao",
                Telefone ="1699455774",
                RG="21391219-7",
                Endereco ="Rua: Salvado Nº22",
                DtaNasci= "22/02/2002"
                },
                new Aluno 
                {
                Nome = "Jordhan",
                Telefone ="169944564",
                RG="614214219-7",
                Endereco ="Rua: Cravinho Nº22",
                DtaNasci= "10/04/2002"
                },
            };

            foreach (Aluno d in aluno)
            {
                context.aluno.Add(d);
            }

            context.SaveChanges();
        }
    }
}
