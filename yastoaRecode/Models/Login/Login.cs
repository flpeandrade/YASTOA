using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace yastoaRecode.Models.Login
{
    [Table("Login")]
    public class Login
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "CPF")]
        [StringLength(14)]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Endereço completo")]
        [StringLength(500)]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Nome")]
        [StringLength(150)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Email")]
        [StringLength(150)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha")]
        [StringLength(50)]
        public string Senha { get; set; }
    }
}
