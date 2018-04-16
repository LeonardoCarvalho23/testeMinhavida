using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeVacina.Models
{
    public class Agenda
    {
        public Agenda()
        {
            Id_Agenda_Usuario = Guid.NewGuid();
        }
        [Key]
        public Guid Id_Agenda_Usuario { get; set; }
        public string Dt_Agendamento { get; set; }
        public Guid Id_Usuario_Vacina { get; set; }

        [ForeignKey("Id_Usuario_Vacina")]
        public virtual Usuario_Vacina Usuario_Vacina { get; set; }
    }

}
