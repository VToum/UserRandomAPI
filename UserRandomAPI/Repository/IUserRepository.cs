using UserRandomAPI.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UserRandomAPI.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<Usuario>> ObterTodosUsuariosAsync(int paginaNumero, int paginaTamanaho);
        Usuario ObterIdUsuario(int id);
        Task AddUsuarioAsync(Usuario usuario);
        Task<bool> DeleteUsuarioAsync(int id);
    }
}
