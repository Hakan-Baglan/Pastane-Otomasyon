using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepsitory;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepsitory = pieRepository;
            _categoryRepository = categoryRepository;
            foreach (Pie item in _pieRepsitory.AllPies)
            {
                item.Category = _categoryRepository.AllCategories.FirstOrDefault(p => p.CategoryId == item.CategoryId);
            }
            Console.WriteLine("Seleam");
        }

        public ViewResult List()
        {
            return View(_pieRepsitory.AllPies);
        }
    }
}
