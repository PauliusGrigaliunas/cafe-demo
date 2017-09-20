using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

public class Kavine
{
    public string _Id { get; private set; } //read-only outside of the class
    public string _name;
    public string _address;
    public string _description;
    public string _phoneNumber;
    public Image _mainImage;
    //protected var locationVar; //placeholder if we decide to do anything with GoogleMaps
    public int _tableCount;
    public int availableTables;
    public float rating;
    public string workingHours;

    //Kavine to Push to SQL
    public Kavine(string name, string address, int tableCount)
    {
        //TODO add checking if string != "", tableCount < 0
        _name = name;
        _address = address;
        _tableCount = tableCount;
        _Id = generateId(); //UNDONE Replace search code with a method that gets a new Id based on a SQL table
    }

    //Kavine to POP from SQL
    public Kavine(string Id)
    {
        _Id = Id;
        //UNDONE SELECT all the data using Id
    }

    private string generateId()
    {
        string generatedId = "";
        //TODO A method to get an Id for a newly registered Kavine
        return generatedId;
    }

    //****** DEPRECATED (useless, but still working functions)
    static string RandomNumberString(int length)
    {
        Random random = new Random();
        const string chars = "0123456789";

        return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    static string RandomTextString(int length)
    {
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }
    //*******************
}
