using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeVacina.Models
{
    public class Vacina
    {
        public Vacina()
        {
            Id_Vacina = Guid.NewGuid();
        }
        [Key]
        public Guid Id_Vacina { get; set; }
        public string Nome { get; set; }
        public DateTime Dt_Criacao { get; set; }
        public DateTime Dt_Atualizacao { get; set; }
        public int Doses_Necessarias { get; set; }

    }
}
