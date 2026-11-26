using Microsoft.AspNetCore.Mvc;
using MyAcademy_PortfolioProject.Context;

namespace MyAcademy_PortfolioProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultAboutComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        PortfolioContext portfolioContext = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = _context.Abouts.FirstOrDefault();
            ViewBag.v1 = values.NameSurname;
            ViewBag.v2 = values.JobTitle;
            ViewBag.v3 = values.Location;
            ViewBag.v4 = values.Expert;
            ViewBag.v5 = values.Email;
            ViewBag.v6 = values.Description;
            ViewBag.v7 = values.OpenToWork;
            return View();
        }
    }
}
