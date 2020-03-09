using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cadastro.Data;
using Cadastro.Models;

namespace Cadastro.Controllers
{
    public class PessoaFisicaController : Controller
    {
        private readonly PessoaFisica_Context _context;

        public PessoaFisicaController(PessoaFisica_Context context)
        {
            _context = context;
        }

        // GET: PessoaFisicas
        [HttpGet]
        public async Task<IActionResult> Index( )
        {
           
           
            var pessoafisica = _context.PessoaFisica
                            .Include(c => c.Endereco)
                            .Include(d => d.Telefone)
                            .AsNoTracking();
            

            return View(await pessoafisica.ToListAsync());
        }

        // GET: PessoaFisicas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoaFisica = await _context.PessoaFisica 
                                             .Include(m => m.Endereco) 
                                             .Include(p=> p.Telefone)
                                             .ThenInclude(b => b.PessoaFisica)
                                             .AsNoTracking()
                                             .FirstOrDefaultAsync(y => y.PessoaFisicaId == id);
            if (pessoaFisica == null)
            {
                return NotFound();
            }

            return View(pessoaFisica);
        }

        // GET: PessoaFisicas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PessoaFisicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PessoaFisicaId,CPF,Nome,RG,Endereco,Telefone")] PessoaFisica pessoaFisica)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(pessoaFisica);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException ex)
            {
                
                ModelState.AddModelError(ex.Message.ToString(), "Erro de persistencia.");
            }
            return View(pessoaFisica);
        }

        // GET: PessoaFisicas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var pessoaFisica = await _context.PessoaFisica 
                                          .Include(m => m.Endereco)
                                          .Include(p => p.Telefone)
                                          .ThenInclude(b => b.PessoaFisica)
                                          .AsNoTracking()
                                          .FirstOrDefaultAsync(y => y.PessoaFisicaId == id);
             if (pessoaFisica == null)
            {
                return NotFound();
            }
            return View(pessoaFisica);
        }

        // POST: PessoaFisicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PessoaFisicaId,CPF,Nome,RG, Endereco,Telefone")] PessoaFisica pessoaFisica)
        {

            if (id != pessoaFisica.PessoaFisicaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pessoaFisica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PessoaFisicaExists(pessoaFisica.PessoaFisicaId))
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
            return View(pessoaFisica);
        }

        // GET: PessoaFisicas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoaFisica = await _context.PessoaFisica
                                             .Include(m => m.Endereco)
                                             .Include(p => p.Telefone)
                                             .ThenInclude(b => b.PessoaFisica)
                                             .AsNoTracking()
                                             .FirstOrDefaultAsync(y => y.PessoaFisicaId == id); 
            if (pessoaFisica == null)
            {
                return NotFound();
            }

            return View(pessoaFisica);
        }

        // POST: PessoaFisicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pessoaFisica = await _context.PessoaFisica.FindAsync(id);
            _context.PessoaFisica.Remove(pessoaFisica);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PessoaFisicaExists(int id)
        {
            return _context.PessoaFisica.Any(e => e.PessoaFisicaId == id);
        }
    }
}
