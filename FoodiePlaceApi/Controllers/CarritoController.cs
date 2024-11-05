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
    public class CarritoController : ControllerBase
    {
        private readonly Contexto _context;

        public CarritoController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Carrito
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Carrito>>> GetCarrito()
        {
            return await _context.Carrito
                .Include(d => d.CarritoDetalle).ToListAsync();
        }

        // GET: api/Carrito/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Carrito>> GetCarrito(int id)
        {
            var carrito = await _context.Carrito
                .Include(d => d.CarritoDetalle)
                .FirstOrDefaultAsync(d => d.CarritoId == id);

            if (carrito == null)
            {
                return NotFound();
            }

            return carrito;
        }

        // PUT: api/Carrito/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarrito(int id, Carrito carrito)
        {
            if (id != carrito.CarritoId)
            {
                return BadRequest();
            }

            _context.Entry(carrito).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarritoExists(id))
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

        // POST: api/Carrito
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Carrito>> PostCarrito(Carrito carrito)
        {
            _context.Carrito.Add(carrito);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarrito", new { id = carrito.CarritoId }, carrito);
        }

        // DELETE: api/Carrito/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarrito(int id)
        {
            var carrito = await _context.Carrito.FindAsync(id);
            if (carrito == null)
            {
                return NotFound();
            }

            _context.Carrito.Remove(carrito);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarritoExists(int id)
        {
            return _context.Carrito.Any(e => e.CarritoId == id);
        }
    }
}
