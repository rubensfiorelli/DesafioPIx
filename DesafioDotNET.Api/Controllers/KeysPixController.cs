using DesafioDotNET.Data.DatabaseContext;
using DesafioDotNET.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DesafioDotNET.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KeysPixController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public KeysPixController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post(KeyPix pix)
        {
            try
            {
                _context.Add(pix);

                await _context.SaveChangesAsync();

                return Ok($"Chave {pix} criada com sucesso!");
            }
            catch
            {

                return BadRequest($"Não foi possivel criar a chave {pix}");
            }
        }



    }
}
