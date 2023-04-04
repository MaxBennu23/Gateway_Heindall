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
    public class ConfigGeraisController : Controller
    {
        private readonly PrincipalContext _context;

        public ConfigGeraisController(PrincipalContext context)
        {
            _context = context;
        }

        // GET: ConfigGerais
        public async Task<IActionResult> Index()
        {
              return View(await _context.ConfigGerais.ToListAsync());
        }

        // GET: ConfigGerais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ConfigGerais == null)
            {
                return NotFound();
            }

            var configGeral = await _context.ConfigGerais
                .FirstOrDefaultAsync(m => m.Id == id);
            if (configGeral == null)
            {
                return NotFound();
            }

            return View(configGeral);
        }

        // GET: ConfigGerais/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ConfigGerais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ConfigType,ConfigNomeDoRecurso,FrequenciaCronJob,TrazOsCancelados")] ConfigGeral configGeral)
        {
            if (ModelState.IsValid)
            {
                _context.Add(configGeral);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(configGeral);
        }

        // GET: ConfigGerais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ConfigGerais == null)
            {
                return NotFound();
            }

            var configGeral = await _context.ConfigGerais.FindAsync(id);
            if (configGeral == null)
            {
                return NotFound();
            }
            return View(configGeral);
        }

        // POST: ConfigGerais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ConfigType,ConfigNomeDoRecurso,FrequenciaCronJob,TrazOsCancelados")] ConfigGeral configGeral)
        {
            if (id != configGeral.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(configGeral);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConfigGeralExists(configGeral.Id))
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
            return View(configGeral);
        }

        // GET: ConfigGerais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ConfigGerais == null)
            {
                return NotFound();
            }

            var configGeral = await _context.ConfigGerais
                .FirstOrDefaultAsync(m => m.Id == id);
            if (configGeral == null)
            {
                return NotFound();
            }

            return View(configGeral);
        }

        // POST: ConfigGerais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ConfigGerais == null)
            {
                return Problem("Entity set 'PrincipalContext.ConfigGerais'  is null.");
            }
            var configGeral = await _context.ConfigGerais.FindAsync(id);
            if (configGeral != null)
            {
                _context.ConfigGerais.Remove(configGeral);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConfigGeralExists(int id)
        {
          return _context.ConfigGerais.Any(e => e.Id == id);
        }
    }
}
