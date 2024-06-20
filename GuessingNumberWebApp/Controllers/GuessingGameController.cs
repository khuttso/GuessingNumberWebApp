using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Fluent;
using PhoneBookWebApp.GuessingNumberImplementation;

namespace PhoneBookWebApp.Controllers;

[ApiController]
[Route("api/GuessingGame")]
public class GuessingGameController : ControllerBase
{
    private static readonly Logger logger = LogManager.GetCurrentClassLogger();
    
    [HttpPost]  
    public IActionResult Process([FromBody] Request request)
    {
        logger.Info("Received request: {@Request}", request);
        if (request.Success)
        {
            logger.Info("Number is guessed. Game over.");

            return Ok(new Response()
            {
                From = request.From,
                To = request.To,
                Answer = request.From,
                Message = $"Number is guessed, Your number is {request.From}, Game over",
                Success = true
            });
        }
        logger.Info($"Returning answer to the user. answer = {request}");
        return Ok(new Response()
        {
            From = request.From,
            To = request.To,
            Answer = (request.From + request.To) / 2,
            Message = $"Is {(request.From + request.To) / 2} your number? If it is send true in success field " +
                      $"and Range From: your number to your number, otherwise send false" +
                      $"If your Number is greater than displayed number, please send From: displayed answer+1 To: old To otherwise u should send From: old From and To: answer" +
                      $"In general u should send data based on fact that your number is answer: or not and respond suitable json data." +
                      $"Good luck",
            Success = false
        });
    }
}