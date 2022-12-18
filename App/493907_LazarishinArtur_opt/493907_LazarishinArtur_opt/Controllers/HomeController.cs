using _493907_LazarishinArtur_opt.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace _493907_LazarishinArtur_opt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var date = new DataViewModel
            {
                KoefTeMatTr = 24,

                KoefTeOneMatIzl = 0.9,
                KoefTeTwoMatIzl = 0.7,
                KoefTeThreeMatIzl = 0.3,

                StoOne = 10,
                StoTwo = 30,
                StoThree = 80,

                SumTolUzl = 0.3,

                D_vnu = 0.2,
                D_vne = 0.23,

                T_okr = 20,
                T_gid = 900,
                T_nar = 30,

                KoefTeplo_vn = 500,
                KoefTeplo_nar = 100,
            };


            return View(date);
        }

        public IActionResult Result(DataViewModel data)
        {
            if (ModelState.IsValid)
            {

                var rez = new ResultViewModel(data);
                var isRes = rez.SolverRun();
                    return View(rez);
            }
            else
                return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Report(DataViewModel dateViewModel)
        {
            var resultViewModel = new ResultViewModel(dateViewModel);
            var isRes = resultViewModel.SolverRun();
            return View(resultViewModel);
        }

    }
}
