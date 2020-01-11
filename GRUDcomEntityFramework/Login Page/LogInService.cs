public class LogInService
{
    public bool LogIn(string email, string password)
    {
        // In real life you will have some server communication here...but for now:
        return email.Equals("valid@email.com") && password.Equals("validPassword");
    }
}