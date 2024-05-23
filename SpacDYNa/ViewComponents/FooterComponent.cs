using Microsoft.AspNetCore.Mvc;

namespace SpacDYNa.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
