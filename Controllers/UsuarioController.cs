﻿using Microsoft.AspNetCore.Mvc;
using UsuarioAPI.Data.Dtos;
using UsuarioAPI.Services;

namespace UsuarioAPI.Controllers;

[ApiController]
[Route("[Controller]")]
public class UsuarioController : ControllerBase
{
    private UsuarioService _usuarioService;

    public UsuarioController(UsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpPost("cadastro")]
    public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto)
    {
        await _usuarioService.Cadastra(dto);
        return Ok("Usuário Cadastrado");
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginUsuarioDto dto)
    {
        await _usuarioService.Login(dto);
        return Ok("Usuário Autenticado");
    }
}
