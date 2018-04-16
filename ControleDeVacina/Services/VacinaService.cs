using ControleDeVacina.Data;
using ControleDeVacina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeVacina.Services
{
    public class VacinaService
    {
        private readonly ApplicationDbContext _ApplicationDbContext;

        public VacinaService(ApplicationDbContext ApplicationDbContext)
        {
            _ApplicationDbContext = ApplicationDbContext;
        }

        public List<Vacina> ObterVacinasCadastradas()
        {
            var Vacinas = _ApplicationDbContext.Vacina.ToList();
            var usuarios = _ApplicationDbContext.Users.ToList();
            var usuarioVacina = _ApplicationDbContext.Usuario_Vacina.ToList();
            return Vacinas;
        }

        public void CadastrarVacina(Vacina vacina) {
            _ApplicationDbContext.Vacina.Add(vacina);
        }

        public void AlterarVacina(Vacina vacina) {
            _ApplicationDbContext.Vacina.Update(vacina);
        }

        public void ExcluirVacina(Vacina vacina) {
            _ApplicationDbContext.Vacina.Remove(vacina);
        }

    }
}
