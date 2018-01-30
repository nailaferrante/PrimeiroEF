using System;
using System.ComponentModel.DataAnnotations;

namespace PrimeiroEF.Models
{
    public class Cliente
    {
        [Key]//data anottations
        public int Id { get; set; }
        [Required]
        [StringLength(50,ErrorMessage="Você deve inserir um nome de até 50 caracteres.")]
        public string Nome { get; set; }
        [Required]
        [StringLength(50,ErrorMessage="Você deve inserir um e-mail de até 50 caracteres.")]
        public string Email { get; set; }
        [Required]
        [Range(1,100)]
        public int Idade { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }
    }
}
//vamos herdar um contexto da api do dotnet para criar e manipular os dados e ajusta-lo.