﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodiePlaceApi.DAL;
using FoodiePlaceApi.Models;

namespace FoodiePlaceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetasController : ControllerBase
    {
        private readonly Contexto _context;

        public TarjetasController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Tarjetas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tarjetas>>> GetTarjetas()
        {
            return await _context.Tarjetas.ToListAsync();
        }

        // GET: api/Tarjetas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tarjetas>> GetTarjetas(int id)
        {
            var tarjetas = await _context.Tarjetas.FindAsync(id);

            if (tarjetas == null)
            {
                return NotFound();
            }

            return tarjetas;
        }

        // PUT: api/Tarjetas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTarjetas(int id, Tarjetas tarjetas)
        {
            if (id != tarjetas.TarjetaId)
            {
                return BadRequest();
            }

            _context.Entry(tarjetas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TarjetasExists(id))
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

        // POST: api/Tarjetas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tarjetas>> PostTarjetas(Tarjetas tarjetas)
        {
            _context.Tarjetas.Add(tarjetas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTarjetas", new { id = tarjetas.TarjetaId }, tarjetas);
        }

        // DELETE: api/Tarjetas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTarjetas(int id)
        {
            var tarjetas = await _context.Tarjetas.FindAsync(id);
            if (tarjetas == null)
            {
                return NotFound();
            }

            _context.Tarjetas.Remove(tarjetas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TarjetasExists(int id)
        {
            return _context.Tarjetas.Any(e => e.TarjetaId == id);
        }
    }
}
