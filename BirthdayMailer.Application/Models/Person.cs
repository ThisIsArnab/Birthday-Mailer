namespace BirthdayMailer.Application.Models;

public class Person
{
    public string FirstName { get; }

    public string LastName { get; }

    public string EmailAddr { get; }

    /**
     *  Day and Month should be stored as datetime in db for facilitating sorting, integrity and validation.
     *  Store as leap year to include 29th Feb date.
     */

    public int DayOfBirth { get; }

    public int MonthOfBirth { get; }

    public DateTime DateOfJoining { get; set; }

    public bool IsActive { get; set; }

    /// <summary>
    /// TODO: Find better alternative to a long constructor
    /// NOTE: Constructor parameter should match propery names for runtime to deserialize properly at [FromBody]
    /// </summary>
    public Person(string firstName, string lastName, string emailAddr, int dayOfBirth, int monthOfBirth, DateTime dateOfJoining, bool isActive)
    {
        FirstName = firstName;
        LastName = lastName;
        EmailAddr = emailAddr;
        DayOfBirth = dayOfBirth;
        MonthOfBirth = monthOfBirth;
        DateOfJoining = dateOfJoining;
        IsActive = isActive;
    }
}
