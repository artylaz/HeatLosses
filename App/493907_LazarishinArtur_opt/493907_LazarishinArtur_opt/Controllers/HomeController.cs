using _493907_LazarishinArtur_opt.Models;
using Microsoft.AspNetCore.Mvc;

namespace _493907_LazarishinArtur_opt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var data = new DataViewModel
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
            
            
            return View(data);
        }

        public IActionResult Result(DataViewModel data)
        {
            var rez = new ResultViewModel(data);
            rez.SolverRun();
            return View(rez);
        }

    }
}
