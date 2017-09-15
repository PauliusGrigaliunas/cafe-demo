using System;
using System.Drawing.Image;

public class Kavine
{
    private string _searchCode { get; } //read-only outside the class

    protected string _name;
    protected string _address;
    protected string _description;
    protected string _phoneNumber;
    protected Image _mainImage;
    //protected var locationVar; //placeholder if we decide to do anything with GoogleMaps
    protected int _tableCount;

    protected int availableTables;

    public Kavine(string name, string address, int tableCount)
    {
        //TODO add checking if string != "", tableCount < 0
        _name = name;
        _address = address;
        _tableCount = tableCount;
        //_mainImage = some stock image
        GenerateAndSet_searchCode();
    }

    private void GenerateAndSet_searchCode()
    {
        string namePart;
        if (_name.Length > 2)                   //jei vardas bent 3 raides
        {                                       //paima 3 raides i _searchCode
            namePart = _name.Substring(0, 3);
        }
        else                                    //kitu atveju sugeneruoja random 3 raides
        {
            namePart = RandomString(3);
        }

        string numberPart = RandomString(3);

        _searchCode = namePart + "-" + numberPart;
    }

    //TODO: split to char string and numeric string
    static string RandomString(int length)
    {
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}
