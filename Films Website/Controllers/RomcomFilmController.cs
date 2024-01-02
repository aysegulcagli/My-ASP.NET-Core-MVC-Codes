using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewFilms.Models;



namespace NewFilms.Controllers
{
    public class RomcomFilmController : Controller
    {
        private readonly FilmContext _context;

        public RomcomFilmController(FilmContext context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            var romcomContext = _context.RomcomFilms;
            return View(await romcomContext.ToListAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null || _context.RomcomFilms == null)
            {
                return NotFound();
            }

            var film = await _context.RomcomFilms


                .FirstOrDefaultAsync(m => m.FilmId == id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FilmId,FilmName,Director,Imdb,ReleasedDate,LeadActor,Genre")] RomcomFilm film)
        {
            if (ModelState.IsValid)
            {
                _context.Add(film);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(film);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null || _context.RomcomFilms == null)
            {
                return NotFound();
            }

            var student = await _context.RomcomFilms.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("FilmId,FilmName,Director,Imdb,ReleasedDate,LeadActor,Genre")] RomcomFilm film)
        {
            if (id != film.FilmId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(film);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmExists(film.FilmId))
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
            return View(film);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null || _context.RomcomFilms == null)
            {
                return NotFound();
            }

            var film = await _context.RomcomFilms

                .FirstOrDefaultAsync(m => m.FilmId == id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            if (_context.RomcomFilms == null)
            {
                return Problem("Entity set 'UniversityContext.Students'  is null.");
            }
            var student = await _context.RomcomFilms.FindAsync(id);
            if (student != null)
            {
                _context.RomcomFilms.Remove(student);
            }

            await _context.SaveChangesAsync();
            TempData["keyMessage"] = "Record deleted succesffuly.";

            return RedirectToAction(nameof(Index));
        }

        private bool FilmExists(short id)
        {
            return (_context.RomcomFilms?.Any(e => e.FilmId == id)).GetValueOrDefault();
        }
    }
}
