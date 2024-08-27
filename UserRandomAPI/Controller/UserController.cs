using Microsoft.AspNetCore.Mvc;
using UserRandomAPI.Repository;
using UserRandomAPI.Services;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IUserRepository _userRepository;

    public UsuarioController(IUserService userService, IUserRepository userRepository)
    {
        _userService = userService;
        _userRepository = userRepository;
    }

    [HttpPost("importar/aleatorio")]
    public async Task<IActionResult> ImportUser()
    {
        try
        {
            await _userService.ImportRandomUserAsync();
            return Ok("Usuario Adicionado com sucesso");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("importar/{quantidade}")]
    public async Task<IActionResult> ImportUserQtd(int quantidade)
    {
        try
        {
            await _userService.ImportRandomUserQtdAsync(quantidade);
            return Ok($"Usuarios Adicionados com sucesso: {quantidade}");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("BuscarTodosUsuarios")]
    public async Task<IActionResult> BuscarTodosUsuario([FromQuery] int paginaNumero = 1, [FromQuery] int paginaTamanaho = 5)
    {
        try
        {
            var usuarios = await _userRepository.ObterTodosUsuariosAsync(paginaNumero, paginaTamanaho);
            return Ok(usuarios);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoverUsuario(int id)
    {
        try
        {
            bool resposta = await _userRepository.DeleteUsuarioAsync(id);

            if (resposta)
            {
                return Ok($"Usuario removido com sucesso: {id}");
            }
            else
            {
                return NotFound($"Usuario não existe");
            }
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
