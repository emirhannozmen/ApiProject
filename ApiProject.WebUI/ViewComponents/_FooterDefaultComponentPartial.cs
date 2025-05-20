using Microsoft.AspNetCore.Mvc;

namespace ApiProject.WebUI.ViewComponents
{
    public class _FooterDefaultComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
