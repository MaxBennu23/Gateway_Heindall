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
    public class IntegradoresdoUserController : Controller
    {
        private readonly PrincipalContext _context;

        public IntegradoresdoUserController(PrincipalContext context)
        {
            _context = context;
        }

        // GET: IntegradoresdoUser
        public async Task<IActionResult> Index()
        {
            var principalContext = _context.IntegradoresdoUser.Include(i => i.Integrador).Include(i => i.UserDadosConex);
            return View(await principalContext.ToListAsync());
        }

        // GET: IntegradoresdoUser/Conexoes
        public async Task<IActionResult> Conexoes()//HELP : Tabelas : Esta linha cria relacionamento com IntegradoresdoUser/View/Details
        {
            var principalContext = _context.IntegradoresdoUser.Include(i => i.Integrador).Include(i => i.UserDadosConex);
            return View(await principalContext.ToListAsync());
        }

        // GET: IntegradoresdoUser/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.IntegradoresdoUser == null)
            {
                return NotFound();
            }

            var integradordoUser = await _context.IntegradoresdoUser
                .Include(i => i.Integrador)
                .Include(i => i.UserDadosConex)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (integradordoUser == null)
            {
                return NotFound();
            }

            return View(integradordoUser);
        }

        // GET: IntegradoresdoUser/Create
        public IActionResult Create()
        {
            ViewData["IntegradorId"] = new SelectList(_context.Integradores, "Id", "Id");
            ViewData["UserDadosConexId"] = new SelectList(_context.UsersDadosConex, "Id", "Id");
            return View();
        }

        // POST: IntegradoresdoUser/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UsuarioIDAgencia,IntegUserUser,IntegUserPass,IntegUserPort,IntegUserPublicKey,IntegUserPrivateKey,IntegradorId,UserDadosConexId")] IntegradordoUser integradordoUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(integradordoUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IntegradorId"] = new SelectList(_context.Integradores, "Id", "Id", integradordoUser.IntegradorId);
            ViewData["UserDadosConexId"] = new SelectList(_context.UsersDadosConex, "Id", "Id", integradordoUser.UserDadosConexId);
            return View(integradordoUser);
        }

        // GET: IntegradoresdoUser/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.IntegradoresdoUser == null)
            {
                return NotFound();
            }

            var integradordoUser = await _context.IntegradoresdoUser.FindAsync(id);
            if (integradordoUser == null)
            {
                return NotFound();
            }
            ViewData["IntegradorId"] = new SelectList(_context.Integradores, "Id", "Id", integradordoUser.IntegradorId);
            ViewData["UserDadosConexId"] = new SelectList(_context.UsersDadosConex, "Id", "Id", integradordoUser.UserDadosConexId);
            return View(integradordoUser);
        }

        // POST: IntegradoresdoUser/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UsuarioIDAgencia,IntegUserUser,IntegUserPass,IntegUserPort,IntegUserPublicKey,IntegUserPrivateKey,IntegradorId,UserDadosConexId")] IntegradordoUser integradordoUser)
        {
            if (id != integradordoUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(integradordoUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IntegradordoUserExists(integradordoUser.Id))
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
            ViewData["IntegradorId"] = new SelectList(_context.Integradores, "Id", "Id", integradordoUser.IntegradorId);
            ViewData["UserDadosConexId"] = new SelectList(_context.UsersDadosConex, "Id", "Id", integradordoUser.UserDadosConexId);
            return View(integradordoUser);
        }

        // GET: IntegradoresdoUser/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.IntegradoresdoUser == null)
            {
                return NotFound();
            }

            var integradordoUser = await _context.IntegradoresdoUser
                .Include(i => i.Integrador)
                .Include(i => i.UserDadosConex)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (integradordoUser == null)
            {
                return NotFound();
            }

            return View(integradordoUser);
        }

        // POST: IntegradoresdoUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.IntegradoresdoUser == null)
            {
                return Problem("Entity set 'PrincipalContext.IntegradoresdoUser'  is null.");
            }
            var integradordoUser = await _context.IntegradoresdoUser.FindAsync(id);
            if (integradordoUser != null)
            {
                _context.IntegradoresdoUser.Remove(integradordoUser);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IntegradordoUserExists(int id)
        {
          return _context.IntegradoresdoUser.Any(e => e.Id == id);
        }
    }
}
