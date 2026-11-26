using Microsoft.AspNetCore.Mvc;
using MyAcademy_PortfolioProject.Context;
using Microsoft.EntityFrameworkCore;

namespace MyAcademy_PortfolioProject.ViewComponents.DefaultViewComponents
{
    public class _DefaultProjectComponentPartial:ViewComponent
    {
        private readonly PortfolioContext _context;
        public _DefaultProjectComponentPartial (PortfolioContext context)
        {
            _context= context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Projects.Include(X=>X.Category).ToList();
            return View(values);
        }
    }
}
