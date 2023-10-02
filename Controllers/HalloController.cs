using Microsoft.AspNetCore.Mvc;

[Route("/one")]

public class hallo : ControllerBase
{
    // List<Doctor> _doctors = new ();

    [HttpGet]
    public IActionResult get()
    {
        return Ok("dfdsh");
    }
    
    [HttpGet("of")]
    public IActionResult getof()
    {
        return Ok("Hamse");
    }
   
}