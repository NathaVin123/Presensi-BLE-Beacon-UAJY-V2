using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Presensi_BLE_Beacon_UAJY.API.Data;
using Presensi_BLE_Beacon_UAJY.API.Models;

namespace Presensi_BLE_Beacon_UAJY.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private readonly Presensi_BLE_Beacon_UAJYContext _context;

        public MahasiswaController(Presensi_BLE_Beacon_UAJYContext context)
        {
            _context = context;
        }

        // GET: api/Mahasiswa
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mahasiswa>>> GetMahasiswa()
        {
            return await _context.Mahasiswa.ToListAsync();
        }

        // GET: api/Mahasiswa/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mahasiswa>> GetMahasiswa(string id)
        {
            var mahasiswa = await _context.Mahasiswa.FindAsync(id);

            if (mahasiswa == null)
            {
                return NotFound();
            }

            return mahasiswa;
        }

        // PUT: api/Mahasiswa/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMahasiswa(string id, Mahasiswa mahasiswa)
        {
            if (id != mahasiswa.NPM)
            {
                return BadRequest();
            }

            _context.Entry(mahasiswa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MahasiswaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Mahasiswa
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mahasiswa>> PostMahasiswa(Mahasiswa mahasiswa)
        {
            _context.Mahasiswa.Add(mahasiswa);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MahasiswaExists(mahasiswa.NPM))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMahasiswa", new { id = mahasiswa.NPM }, mahasiswa);
        }

        // DELETE: api/Mahasiswa/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMahasiswa(string id)
        {
            var mahasiswa = await _context.Mahasiswa.FindAsync(id);
            if (mahasiswa == null)
            {
                return NotFound();
            }

            _context.Mahasiswa.Remove(mahasiswa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MahasiswaExists(string id)
        {
            return _context.Mahasiswa.Any(e => e.NPM == id);
        }
    }
}
