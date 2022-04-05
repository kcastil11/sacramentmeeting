using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Data;
using SacramentPlanner.Models;

namespace SacramentPlanner.Controllers
{
    public class SacramentProgramsController : Controller
    {
        private readonly SacramentContext _context;

        public SacramentProgramsController(SacramentContext context)
        {
            _context = context;
        }

        // GET: SacramentPrograms
        public async Task<IActionResult> Index()
        {
            return View(await _context.Programs.ToListAsync());
        }

        // GET: SacramentPrograms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacramentProgram = await _context.Programs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sacramentProgram == null)
            {
                return NotFound();
            }

            return View(sacramentProgram);
        }

        // GET: SacramentPrograms/Create
        public async Task<IActionResult> Create()
        {
            var members = await _context.Members.ToListAsync();
            var viewList = new SelectList(members,"Id", "Fullname");


            ViewBag.Members = viewList;

            return View();
        }

        // POST: SacramentPrograms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OpeningSong,SacramentHymn,ClosingSong,ConductingLeaderId,MusicalNumber,OpeningPrayer,ClosingPrayer,ProgramDate")] SacramentProgram sacramentProgram)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sacramentProgram);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sacramentProgram);
        }

        // GET: SacramentPrograms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacramentProgram = await _context.Programs.FindAsync(id);
            if (sacramentProgram == null)
            {
                return NotFound();
            }
            return View(sacramentProgram);
        }

        // POST: SacramentPrograms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OpeningSong,SacramentHymn,ClosingSong,ConductingLeaderId,MusicalNumber,OpeningPrayer,ClosingPrayer,ProgramDate")] SacramentProgram sacramentProgram)
        {
            if (id != sacramentProgram.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sacramentProgram);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SacramentProgramExists(sacramentProgram.Id))
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
            return View(sacramentProgram);
        }

        // GET: SacramentPrograms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sacramentProgram = await _context.Programs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sacramentProgram == null)
            {
                return NotFound();
            }

            return View(sacramentProgram);
        }

        // POST: SacramentPrograms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sacramentProgram = await _context.Programs.FindAsync(id);
            _context.Programs.Remove(sacramentProgram);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SacramentProgramExists(int id)
        {
            return _context.Programs.Any(e => e.Id == id);
        }
    }
}
