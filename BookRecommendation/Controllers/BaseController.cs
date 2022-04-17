using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookRecommendation.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

    }
}
