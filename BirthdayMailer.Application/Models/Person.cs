namespace BirthdayMailer.Application.Models;

public class PersonController
{
    public string FirstName { get; }

    public string LastName { get; }

    public string Email { get; }

    /**
     *  TODO: Need to see how to better represent day and month of birth
     *  in db as well in model.
     */

    public int DayOfBirth { get; }

    public int MonthOfBirth { get; }

    public PersonController(string firstName, string lastName, string email, int dayOfBirth, int monthOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        DayOfBirth = dayOfBirth;
        MonthOfBirth = monthOfBirth;
    }
}
