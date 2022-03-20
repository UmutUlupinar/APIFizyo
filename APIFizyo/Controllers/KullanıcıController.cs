using APIFizyo.Data;
using APIFizyo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIFizyo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullanıcıController : ControllerBase
    {
        private readonly APIFizyoDBContext _context;

        public KullanıcıController(APIFizyoDBContext context)
        {
            _context = context;
        }

        // GET: api/Kullanıcıları getir
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kullanıcı>>> TümKullanıcılarıGetir()
        {
            return await _context.Kullanıcılar.ToListAsync();
        }

        // GET: api/Kullanıcıyı getir
        [HttpGet("seçiliKullanıcıyıGetir/{id}")]
        public async Task<ActionResult<Kullanıcı>> seçiliKullanıcıyıGetir(int id)
        {
            return await _context.Kullanıcılar.FindAsync(id);
        }

        [HttpGet("KullanıcıByRol/{id}")]
        public async Task<ActionResult<IEnumerable<Kullanıcı>>> KullanıcıByRol(int id)
        {
            return await _context.Kullanıcılar.Where(a => a.RolID == id).ToListAsync();
        }

        [HttpGet("KullanıcıByRolAdı/{Adı}")]
        public async Task<ActionResult<IEnumerable<Kullanıcı>>> KullanıcıByRolAdı(string Adı)
        {
            return await _context.Kullanıcılar.Include(a => a.Rol).Where(a => a.Rol.RolAdı == Adı).ToListAsync();
        }

        // POST: api/Kullanıcı

        [HttpPost]
        public async Task<ActionResult<Kullanıcı>> KullanıcıEkle(Kullanıcı kullanıcı)
        {
            _context.Add(kullanıcı);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PUT: api/Kullanıcı/5

        [HttpPut("{id}")]
        public async Task<ActionResult<Kullanıcı>> KullanıcıGüncelle(int id, Kullanıcı kullanıcı)
        {
            _context.Entry(kullanıcı).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return await _context.Kullanıcılar.FindAsync(id);
       
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> KullanıcıSil(int id)
        {
            Kullanıcı kullanıcı = await _context.Kullanıcılar.FindAsync(id);
            _context.Remove(kullanıcı);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet("KullanıcıByRolAdı/{EpostaUzantı}/{RolAdı}")]
        public async Task<ActionResult<IEnumerable<Kullanıcı>>> KullanıcıFiltreli(string EpostaUzantı, string RolAdı)
        {
            return await _context.Kullanıcılar.Include(a => a.Rol).Where(a => (a.Rol.RolAdı == RolAdı||a.Rol.RolAdı==null) && (a.Eposta.Contains(EpostaUzantı)||EpostaUzantı==null)).ToListAsync();
        }



    }
        
}
