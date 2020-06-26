using CalculoJuros.Domain.Common.Interfaces;
using CalculoJuros.Domain.Usuarios.Entities;

namespace CalculoJuros.Domain.Usuarios.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        bool Login(string email, string senha);
    }
}