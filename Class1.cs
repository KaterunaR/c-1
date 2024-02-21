using System;

public class PostalAddress
{
    private string country;
    private string city;
    private string street;
    private string postalCode;

     public PostalAddress()
    {
        country = "Ukraine";
        city = "Lviv";
        street = "Pryrodna";
        postalCode = "82500";
    }

    public PostalAddress(string country, string city, string street, string postalCode)
    {
        SetCountry(country);
        SetCity(city);
        SetStreet(street);
        SetPostalCode(postalCode);
    }

    public string Country
    {
        get { return country; }
        set { SetCountry(value); }
    }

    public string City
    {
        get { return city; }
        set { SetCity(value); }
    }

    public string Street
    {
        get { return street; }
        set { SetStreet(value); }
    }

    public string PostalCode
    {
        get { return postalCode; }
        set { SetPostalCode(value); }
    }

    private void SetCountry(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Country cannot be null or empty.");
        }

        country = value;
    }

    private void SetCity(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("City cannot be null or empty.");
        }

        city = value;
    }

    private void SetStreet(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Street cannot be null or empty.");
        }

        street = value;
    }

    private void SetPostalCode(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Postal code cannot be null or empty.");
        }

        if (value.Length != 5)
        {
            throw new ArgumentException("Postal code must be exactly 5 characters long.");
        }

        postalCode = value;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Postal Address: Country = {country}, City = {city}, Street = {street}, Postal Code = {postalCode}");
    }
}
