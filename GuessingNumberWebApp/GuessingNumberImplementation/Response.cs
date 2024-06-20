namespace PhoneBookWebApp.GuessingNumberImplementation;


/// <summary>
///     class <c>Response</c>> - Data for handling requests sending by user
/// </summary>
public class Response
{
    public int From { get; set; }
    public int To { get; set; }
    public int Answer { get; set; }
    public bool Success { get; set; }
    public string Message { get; set; }
}