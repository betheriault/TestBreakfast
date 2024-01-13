using Microsoft.AspNetCore.Mvc;

namespace TestBreakfast.Controllers;

public class ErrorsController : ControllerBase
{
    [Route("/error")]

    public IActionResult Error()
    {
        return Problem();
    }
}