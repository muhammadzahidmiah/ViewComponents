using Microsoft.AspNetCore.Mvc;
namespace ViewComponents.Components
{
    public class TopBooksViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
