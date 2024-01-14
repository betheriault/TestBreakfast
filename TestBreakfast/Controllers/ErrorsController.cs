using Microsoft.AspNetCore.Mvc;

namespace TestBreakfast.Controllers;

public class ErrorsController : ApiController
{
    [Route("/error")]

    public IActionResult Error()
    {
        return Problem();
    }
}