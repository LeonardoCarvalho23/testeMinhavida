using ControleDeVacina.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeVacina.Services
{
    public class AgendaService
    {
        public ApplicationDbContext _ApplicationDbContext { get; set; }

        public AgendaService(ApplicationDbContext ApplicationDbContext)
        {
            _ApplicationDbContext = ApplicationDbContext;
        }


    }
}
