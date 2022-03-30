using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TruckTravelsCRUD.Models;

namespace TruckTravelsCRUD.Controllers
{
    public class TravelController : Controller
    {
        private readonly DataBase _context;

        public TravelController(DataBase context)
        {
            _context = context;
        }

        // GET: Travels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Travel.ToListAsync());
        }

        // GET: Travels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var travel = await _context.Travel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (travel == null)
            {
                return NotFound();
            }

            return View(travel);
        }

        // GET: Travels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Travels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,DriverId,Destination,StartFrom,TotalDistance")] Travel travel)
        {
            var driversIds = _context.Driver.Select(x => x.Id).ToList();
            if (ModelState.IsValid)
            {
                if (driversIds.Contains(travel.DriverId))
                {
                    TempData["success-message"] = "Viagem adicionada com sucesso!";
                    _context.Add(travel);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["error-message"] = "O identificador informado não existe!";
                }
            }
            return View(travel);
        }

        // GET: Travels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                TempData["error-message"] = "Viagem não encontrada.";
                return NotFound();
            }

            var travel = await _context.Travel.FindAsync(id);
            if (travel == null)
            {
                return NotFound();
            }
            return View(travel);
        }

        // POST: Travels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,DriverId,Destination,StartFrom,TotalDistance")] Travel travel)
        {
            var driversIds = _context.Driver.Select(x => x.Id).ToList();
            if (id != travel.Id)
            {
                TempData["error-message"] = "Viagem não encontrada.";
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (driversIds.Contains(travel.DriverId))
                    {
                        _context.Update(travel);
                        await _context.SaveChangesAsync();
                        TempData["success-message"] = "Viagem editada com sucesso!";
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        TempData["error-message"] = "O identificador informado não existe!";
                    }
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TravelExists(travel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(travel);
        }

        // GET: Travels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                TempData["error-message"] = "Viagem não encontrada.";
                return NotFound();
            }

            var travel = await _context.Travel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (travel == null)
            {
                TempData["error-message"] = "Viagem não encontrada.";
                return NotFound();
            }

            return View(travel);
        }

        // POST: Travels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var travel = await _context.Travel.FindAsync(id);
            _context.Travel.Remove(travel);
            await _context.SaveChangesAsync();
            TempData["success-message"] = "Viagem deletada com sucesso.";

            return RedirectToAction(nameof(Index));
        }

        private bool TravelExists(int id)
        {
            return _context.Travel.Any(e => e.Id == id);
        }
    }
}
