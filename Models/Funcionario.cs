/*
Referências
https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/validation?view=aspnetcore-5.0
https://stackoverflow.com/questions/11651254/how-to-change-the-display-name-for-labelfor-in-razor-in-mvc3
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PamelaProjeto.Models
{
    public class Funcionario
    {
        [Key]
        [StringLength(14)]
        [Required(ErrorMessage = "CPF é obrigatório")]
        public string CPF { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Sexo é obrigatório")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "PIS é obrigatório")]
        public string PIS { get; set; }

        [DisplayName("Salário")]
        [Required(ErrorMessage = "Salário é obrigatório")]
        [DataType(DataType.Currency)]
        public decimal Salario { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "E-mail é obrigatório")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Data de Admissão")]
        [Required(ErrorMessage = "Entre com a data de admissão corretamente")]
        [DataType(DataType.Date)]
        public DateTime DataAdmissao { get; set; }
    }
}