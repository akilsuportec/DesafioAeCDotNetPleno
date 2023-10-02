using ClimaAPI.Data;
using ClimaAPI.Models;

namespace ClimaAPI.Repositorios
{
    public class ClimaAPIRepositorio : IClimaAPIRepositorio
    {
        private readonly ClimaAPIDBContext _climaAPIDBContext;

        public ClimaAPIRepositorio(ClimaAPIDBContext climaAPIDBContext)
        {
            _climaAPIDBContext = climaAPIDBContext;
        }

        public bool Adicionar(Clima clima)
        {
            _climaAPIDBContext.Add(clima);

            int linhasSalva = _climaAPIDBContext.SaveChanges();

            if (linhasSalva > 0)
                return true;
            
            return false;
        }
    }
}
