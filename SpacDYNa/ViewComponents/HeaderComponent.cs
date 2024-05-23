using Microsoft.AspNetCore.Mvc;

namespace SpacDYNa.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
