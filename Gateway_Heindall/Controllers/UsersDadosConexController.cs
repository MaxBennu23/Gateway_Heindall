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
    public class UsersDadosConexController : Controller
    {
        private readonly PrincipalContext _context;

        public UsersDadosConexController(PrincipalContext context)
        {
            _context = context;
        }

        // GET: UsersDadosConex
        public async Task<IActionResult> Index()
        {
              return View(await _context.UsersDadosConex.ToListAsync());
        }

        // GET: UsersDadosConex/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.UsersDadosConex == null)
            {
                return NotFound();
            }

            var userDadosConex = await _context.UsersDadosConex



            .Include(g => g.IntegradoresdoUser)//HELP : Tabelas : Esta linha cria relacionamento com UserDados/View/Details E Conexoes

            .ThenInclude(i => i.Integrador) // Depois com Integradores

            

                .FirstOrDefaultAsync(m => m.Id == id);
            if (userDadosConex == null)
            {
                return NotFound();
            }

            return View(userDadosConex);
        }

        // GET: UsersDadosConex/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsersDadosConex/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserCNPJ,UserNivel,UserNomeEmpresa,UserHostDestino,UserHostUserDestino,UserSenhaDestino,UserPortDestino,UserBancoDestino")] UserDadosConex userDadosConex)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userDadosConex);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userDadosConex);
        }

        // GET: UsersDadosConex/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.UsersDadosConex == null)
            {
                return NotFound();
            }

            var userDadosConex = await _context.UsersDadosConex.FindAsync(id);
            if (userDadosConex == null)
            {
                return NotFound();
            }
            return View(userDadosConex);
        }

        // POST: UsersDadosConex/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserCNPJ,UserNivel,UserNomeEmpresa,UserHostDestino,UserHostUserDestino,UserSenhaDestino,UserPortDestino,UserBancoDestino")] UserDadosConex userDadosConex)
        {
            if (id != userDadosConex.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userDadosConex);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserDadosConexExists(userDadosConex.Id))
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
            return View(userDadosConex);
        }

        // GET: UsersDadosConex/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.UsersDadosConex == null)
            {
                return NotFound();
            }

            var userDadosConex = await _context.UsersDadosConex
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userDadosConex == null)
            {
                return NotFound();
            }

            return View(userDadosConex);
        }

        // POST: UsersDadosConex/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.UsersDadosConex == null)
            {
                return Problem("Entity set 'PrincipalContext.UsersDadosConex'  is null.");
            }
            var userDadosConex = await _context.UsersDadosConex.FindAsync(id);
            if (userDadosConex != null)
            {
                _context.UsersDadosConex.Remove(userDadosConex);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserDadosConexExists(int id)
        {
          return _context.UsersDadosConex.Any(e => e.Id == id);
        }
    }
}
