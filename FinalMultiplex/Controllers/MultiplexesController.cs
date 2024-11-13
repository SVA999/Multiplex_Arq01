using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalMultiplex.Data;
using b_Multiplex.Clases;

namespace FinalMultiplex.Controllers
{
    public class MultiplexesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MultiplexesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Multiplexes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Multiplex.ToListAsync());
        }

        // GET: Multiplexes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var multiplex = await _context.Multiplex
                .FirstOrDefaultAsync(m => m.Id == id);
            if (multiplex == null)
            {
                return NotFound();
            }

            return View(multiplex);
        }

        // GET: Multiplexes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Multiplexes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Direccion")] Multiplex multiplex)
        {
            if (ModelState.IsValid)
            {
                _context.Add(multiplex);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(multiplex);
        }

        // GET: Multiplexes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var multiplex = await _context.Multiplex.FindAsync(id);
            if (multiplex == null)
            {
                return NotFound();
            }
            return View(multiplex);
        }

        // POST: Multiplexes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Direccion")] Multiplex multiplex)
        {
            if (id != multiplex.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(multiplex);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MultiplexExists(multiplex.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(multiplex);
        }

        // GET: Multiplexes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var multiplex = await _context.Multiplex
                .FirstOrDefaultAsync(m => m.Id == id);
            if (multiplex == null)
            {
                return NotFound();
            }

            return View(multiplex);
        }

        // POST: Multiplexes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var multiplex = await _context.Multiplex.FindAsync(id);
            if (multiplex != null)
            {
                _context.Multiplex.Remove(multiplex);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MultiplexExists(int id)
        {
            return _context.Multiplex.Any(e => e.Id == id);
        }
    }
}
