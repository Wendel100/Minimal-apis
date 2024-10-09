using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Minimals_Apis.Dominio.Entidades
{
    public class Admininistrador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     public int Id { get; set; }= default;
     [Required]
     [StringLength(255)]
      public string Email { get; set; }= default;
         [Required]
     [StringLength(50)]

       public string Senha { get; set; }= default;
    [Required]
     [StringLength(10)]
        public string Perfil { get; set; }= default;
    }
}