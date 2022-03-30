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
    public class DriverController : Controller
    {
        private readonly DataBase _context;

        public DriverController(DataBase context)
        {
            _context = context;
        }

        // GET: Driver
        public async Task<IActionResult> Index()
        {
            return View(await _context.Driver.ToListAsync());
        }

        // GET: Driver/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                TempData["error-message"] = "Motorista não encontrado.";

                return NotFound();
            }

            var driver = await _context.Driver
                .FirstOrDefaultAsync(m => m.Id == id);
            if (driver == null)
            {
                return NotFound();
            }

            return View(driver);
        }

        // GET: Driver/Create
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,TruckPlate,Address")] Driver driver)
        {
            var trucksPlates = _context.Trucks.Select(x => x.Plate);
            if (ModelState.IsValid)
            {
                if(driver.TruckPlate != null && trucksPlates.Contains(driver.TruckPlate))
                {
                    _context.Add(driver);
                    await _context.SaveChangesAsync();
                    TempData["success-message"] = "Motorista cadastrado com sucesso.";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["error-message"] = "A placa informada não existe no sistema!";
                }
            }
            return View(driver);
        }

        // GET: Driver/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                TempData["error-message"] = "Motorista não encontrado.";

                return NotFound();
            }

            var driver = await _context.Driver.FindAsync(id);
            if (driver == null)
            {
                return NotFound();
            }
            return View(driver);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,TruckPlate,Address")] Driver driver)
        {
            var trucksPlates = _context.Trucks.Select(x => x.Plate);

            if (id != driver.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (driver.TruckPlate != null && trucksPlates.Contains(driver.TruckPlate))
                    {
                        _context.Update(driver);
                        await _context.SaveChangesAsync();
                        TempData["success-message"] = "Motorista editado com sucesso.";
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        TempData["error-message"] = "A placa informada não existe no sistema!";
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    TempData["error-message"] = "Erro ao editar motorista.";
                    if (!DriverExists(driver.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(driver);
        }

        // GET: Driver/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                TempData["error-message"] = "Motorista não encontrado.";

                return NotFound();
            }

            var driver = await _context.Driver
                .FirstOrDefaultAsync(m => m.Id == id);
            if (driver == null)
            {
                return NotFound();
            }

            return View(driver);
        }

        // POST: Driver/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var driver = await _context.Driver.FindAsync(id);
            _context.Driver.Remove(driver);
            await _context.SaveChangesAsync();

            TempData["success-message"] = "Motorista deletado com sucesso.";

            return RedirectToAction(nameof(Index));
        }

        private bool DriverExists(int id)
        {
            return _context.Driver.Any(e => e.Id == id);
        }
    }
}
