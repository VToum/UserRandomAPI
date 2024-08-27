using Microsoft.EntityFrameworkCore;
using UserRandomAPI.Dao;
using UserRandomAPI.Entity;
using System;
using Microsoft.AspNetCore.Http.HttpResults;

namespace UserRandomAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DaoContext _repo;

        public UserRepository(DaoContext repo)
        {
            _repo = repo;
        }

        public async Task AddUsuarioAsync(Usuario usuario)
        {
            try
            {
                _repo.usuarios.Add(usuario);
                await _repo.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao adicionar usuário: {ex.Message}");
            }
        }

        public async Task<bool> DeleteUsuarioAsync(int id)
        {
            try
            {
                var usuario = await _repo.usuarios.FindAsync(id);

                if (usuario != null)
                {
                    _repo.usuarios.Remove(usuario);
                    await _repo.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao deletar usuário: {ex.Message}");
            }
        }

        public Usuario ObterIdUsuario(int id)
        {
            try
            {
                return _repo.usuarios.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter usuário: {ex.Message}");
            }
        }
        public async Task<IEnumerable<Usuario>> ObterTodosUsuariosAsync(int paginaNumero, int paginaTamanaho)
        {
            try
            {
                var usuarios = await _repo.usuarios
                    .Include(u => u.name)
                    .Include(u => u.login)
                    .Include(u => u.location)
                        .ThenInclude(l => l.street)
                    .Skip((paginaNumero - 1) * paginaTamanaho)
                    .Take(paginaTamanaho)
                    .ToListAsync();

                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter todos os usuários: {ex.Message}");
            }
        }
    }
}
