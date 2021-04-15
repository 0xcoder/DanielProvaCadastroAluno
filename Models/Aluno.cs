using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroAluno.Models
{
    public class Aluno
    {
        [Key]
        public long Id { get; set; }

        [Display(Name ="Nome: ")]
        [Required(ErrorMessage ="Nome Obrigatorio!")]
        public string Nome { get; set; }

        [Display(Name = "Telefone: ")]
        [Required(ErrorMessage = "Telefone Obrigatorio!")]
        public string Telefone { get; set; }

        [Display(Name = "RG: ")]
        [Required(ErrorMessage = "RG Obrigatorio!")]
        public string RG { get; set; }

        [Display(Name = "Endereço: ")]
        [Required(ErrorMessage = "Endereço Obrigatorio!")]
        public string Endereco { get; set; }
        public string DtaNasci { get; set; }



    }
}
