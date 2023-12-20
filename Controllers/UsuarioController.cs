using Microsoft.AspNetCore.Mvc;
using UsuarioAPI.Data.Dtos;

namespace UsuarioAPI.Controllers;

[ApiController]
[Route("[Controller]")]
public class UsuarioController : ControllerBase
{
    [HttpPost]
    public IActionResult CadastraUsuario(CreateUsuarioDto dto)
    {
        throw new NotImplementedException();
    }
}
