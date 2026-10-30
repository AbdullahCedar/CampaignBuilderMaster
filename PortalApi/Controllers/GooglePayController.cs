using Microsoft.AspNetCore.Mvc;
using BLL.Interfaces;
using DAL.VM;
using static BLL.Services.GooglePayService; // Ensure you're using the correct namespace for the interface

[ApiController]
[Route("api/[controller]")]
public class GooglePayController : ControllerBase
{
    private readonly IGooglepayService _googlePayService;

    public GooglePayController(IGooglepayService googlePayService) // Use the interface, not the concrete class
    {
        _googlePayService = googlePayService;
    }

    [HttpPost("process-google-pay")]
    public async Task<IActionResult> ProcessGooglePayToken([FromBody] GooglePayRequest request)
    {
        if (request.GooglePayToken == null || request.Customer == null)
        {
            return BadRequest("Invalid Google Pay token or customer data.");
        }

        try
        {
            var result = await _googlePayService.ProcessGooglePayTokenAsync(request.GooglePayToken, request.Customer);
            return Ok(new { message = "Payment processed successfully", data = result });
        }
        catch (PaymentProcessingException ex)
        {
            return StatusCode(500, new { message = "Payment failed", error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "An error occurred while processing the payment", error = ex.Message });
        }
    }

}
