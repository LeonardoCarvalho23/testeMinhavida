using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeVacina.Models
{
    public class Usuario_Vacina
    {
        public Usuario_Vacina()
        {
            Id_Usuario_Vacina = Guid.NewGuid();
        }
        [Key]
        public Guid Id_Usuario_Vacina { get; set; }
        public string UserId { get; set; }
        public Guid Id_Vacina { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }

        [ForeignKey("Id_Vacina")]
        public virtual Vacina Vacina { get; set; }
    }
}
