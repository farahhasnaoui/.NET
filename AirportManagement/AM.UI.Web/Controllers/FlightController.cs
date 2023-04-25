using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AM.UI.Web.Controllers
{
    public class FlightController : Controller
    {
         IUnitOfWork UnitOfWorkservice;
         IFlightService  flightService;
        public FlightController(IUnitOfWork UnitOfWorkservice, IFlightService flightService)
        {
            this.UnitOfWorkservice = UnitOfWorkservice;
            this.flightService = flightService;

        }
     

        // GET: Floght/Details/5
        public ActionResult Details(int id)
        {
            return View(flightService.GetById(id));
        }

        // GET: Floght/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Floght/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Flight flight)
        {
            try
            {
                flightService.Add(flight);
                UnitOfWorkservice.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Floght/Edit/5
        public ActionResult Edit(int id)
        {
            return View(flightService.GetById(id));
        }

        // POST: Floght/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Flight flight)
        {
            try
            {
                flightService.Update(flight);
                UnitOfWorkservice.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Floght/Delete/5
        public ActionResult Delete(int id)
        {
            return View(flightService.GetById(id));
        }

        // POST: Floght/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Flight flight)
        {
            try
            {
                flight.FlightId= id;
                flightService.Delete(flight);
                UnitOfWorkservice.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Index(DateTime? date)
        {
            if (date == null)
                return View(flightService.GetAll());
            else
                return
                View(flightService.GetFlightsByDate((DateTime)date));
        }


    }
}
