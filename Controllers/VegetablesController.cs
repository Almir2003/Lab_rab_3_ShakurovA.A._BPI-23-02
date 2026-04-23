using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_rab_3._Shakurov_Almir_БПИ_23_02.Models;

namespace Lab_rab_3._Shakurov_Almir_БПИ_23_02.Controllers
{
    public class VegetablesController : Controller
    {
        public ActionResult FirstViewMethod()
        {
            var veggies = GetVegetables();
            return View(veggies);
        }

        public ActionResult SecondViewMethod()
        {
            var veggies = GetVegetables();
            var sorted = veggies.OrderBy(v => v.Name).ToList();
            return View(sorted);
        }

        public ActionResult ThirdViewMethod()
        {
            var veggies = GetVegetables();

            var grouped = veggies
                .GroupBy(v => v.Name[0])
                .OrderBy(g => g.Key)
                .ToList();

            return View(grouped);
        }

        private List<Vegetable> GetVegetables()
        {
            return new List<Vegetable>
        {
            new Vegetable { Id = 1, Name = "Банан" },
            new Vegetable { Id = 2, Name = "Яблоко" },
            new Vegetable { Id = 3, Name = "Апельсин" },
            new Vegetable { Id = 4, Name = "Абрикос" },
            new Vegetable { Id = 5, Name = "Арбуз" }
        };

        }
    }
}
