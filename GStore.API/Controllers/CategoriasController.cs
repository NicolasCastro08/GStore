using GStore.API.Data;
using GStore.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GStore.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriasController : ControllerBase

{
    private readonly AppDbContext _context;

    public CategoriasController(AppDbContext context)
    {
        _context = context;
    }


    [HttpGet("{id}")]
    public ActionResult<Categoria> GetCategoria(int id)
    {
        var categoria = _context.Categorias.Find(id);
        if (categoria == null) return NotFound("Categoria não encontrada");
        return Ok(categoria);
    }
}