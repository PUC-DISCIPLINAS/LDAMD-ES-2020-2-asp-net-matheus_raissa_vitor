using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using covid_dashboard_aspnet_core.Data;
using covid_dashboard_aspnet_core.Models;

namespace covid_dashboard_aspnet_core.Controllers
{
    public class DataCovidsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DataCovidsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DataCovids
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DataCovid.Include(d => d.Country);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DataCovids/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataCovid = await _context.DataCovid
                .Include(d => d.Country)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataCovid == null)
            {
                return NotFound();
            }

            return View(dataCovid);
        }

        // GET: DataCovids/Create
        public IActionResult Create()
        {
            ViewData["CountryId"] = new SelectList(_context.Country, "Id", "Name");
            return View();
        }

        // POST: DataCovids/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ConfirmedCase,Death,Recovered,CountryId")] DataCovid dataCovid)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dataCovid);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryId"] = new SelectList(_context.Country, "Id", "Name", dataCovid.CountryId);
            return View(dataCovid);
        }

        // GET: DataCovids/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataCovid = await _context.DataCovid.FindAsync(id);
            if (dataCovid == null)
            {
                return NotFound();
            }
            ViewData["CountryId"] = new SelectList(_context.Country, "Id", "Name", dataCovid.CountryId);
            return View(dataCovid);
        }

        // POST: DataCovids/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ConfirmedCase,Death,Recovered,CountryId")] DataCovid dataCovid)
        {
            if (id != dataCovid.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dataCovid);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DataCovidExists(dataCovid.Id))
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
            ViewData["CountryId"] = new SelectList(_context.Country, "Id", "Name", dataCovid.CountryId);
            return View(dataCovid);
        }

        // GET: DataCovids/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataCovid = await _context.DataCovid
                .Include(d => d.Country)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dataCovid == null)
            {
                return NotFound();
            }

            return View(dataCovid);
        }

        // POST: DataCovids/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dataCovid = await _context.DataCovid.FindAsync(id);
            _context.DataCovid.Remove(dataCovid);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DataCovidExists(int id)
        {
            return _context.DataCovid.Any(e => e.Id == id);
        }
    }
}
