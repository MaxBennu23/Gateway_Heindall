using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gateway_Heindall.Data;
using Gateway_Heindall.Models;

namespace Gateway_Heindall.Controllers
{
    public class IntegradoresdoUserTempController : Controller
    {
        private readonly PrincipalContext _context;

        public IntegradoresdoUserTempController(PrincipalContext context)
        {
            _context = context;
        }

        // GET: IntegradoresdoUserTemp
        public async Task<IActionResult> Index()
        {
            var principalContext = _context.IntegradoresdoUserTemp.Include(i => i.Integrador);
            return View(await principalContext.ToListAsync());
        }

        // GET: IntegradoresdoUserTemp/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.IntegradoresdoUserTemp == null)
            {
                return NotFound();
            }

            var integradordoUserTemp = await _context.IntegradoresdoUserTemp
                .Include(i => i.Integrador)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (integradordoUserTemp == null)
            {
                return NotFound();
            }

            return View(integradordoUserTemp);
        }

        // GET: IntegradoresdoUserTemp/Create
        public IActionResult Create()
        {
            ViewData["IntegradorId"] = new SelectList(_context.Integradores, "Id", "Id");
            return View();
        }

        // POST: IntegradoresdoUserTemp/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IntegradorNomeTemp,UsuarioIDAgenciaTemp,GrupoUserTemp,GrupoPasswordTemp,GrupoPortTemp,PublicKeyTemp,PrivateKeyTempTemp,IntegradorId,UserId")] IntegradordoUserTemp integradordoUserTemp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(integradordoUserTemp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IntegradorId"] = new SelectList(_context.Integradores, "Id", "Id", integradordoUserTemp.IntegradorId);
            return View(integradordoUserTemp);
        }

        // GET: IntegradoresdoUserTemp/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.IntegradoresdoUserTemp == null)
            {
                return NotFound();
            }

            var integradordoUserTemp = await _context.IntegradoresdoUserTemp.FindAsync(id);
            if (integradordoUserTemp == null)
            {
                return NotFound();
            }
            ViewData["IntegradorId"] = new SelectList(_context.Integradores, "Id", "Id", integradordoUserTemp.IntegradorId);
            return View(integradordoUserTemp);
        }

        // POST: IntegradoresdoUserTemp/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IntegradorNomeTemp,UsuarioIDAgenciaTemp,GrupoUserTemp,GrupoPasswordTemp,GrupoPortTemp,PublicKeyTemp,PrivateKeyTempTemp,IntegradorId,UserId")] IntegradordoUserTemp integradordoUserTemp)
        {
            if (id != integradordoUserTemp.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(integradordoUserTemp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IntegradordoUserTempExists(integradordoUserTemp.Id))
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
            ViewData["IntegradorId"] = new SelectList(_context.Integradores, "Id", "Id", integradordoUserTemp.IntegradorId);
            return View(integradordoUserTemp);
        }

        // GET: IntegradoresdoUserTemp/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.IntegradoresdoUserTemp == null)
            {
                return NotFound();
            }

            var integradordoUserTemp = await _context.IntegradoresdoUserTemp
                .Include(i => i.Integrador)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (integradordoUserTemp == null)
            {
                return NotFound();
            }

            return View(integradordoUserTemp);
        }

        // POST: IntegradoresdoUserTemp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.IntegradoresdoUserTemp == null)
            {
                return Problem("Entity set 'PrincipalContext.IntegradoresdoUserTemp'  is null.");
            }
            var integradordoUserTemp = await _context.IntegradoresdoUserTemp.FindAsync(id);
            if (integradordoUserTemp != null)
            {
                _context.IntegradoresdoUserTemp.Remove(integradordoUserTemp);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IntegradordoUserTempExists(int id)
        {
          return _context.IntegradoresdoUserTemp.Any(e => e.Id == id);
        }
    }
}
