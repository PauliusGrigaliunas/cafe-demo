using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

public class Kavine
{
    public string _searchCode { get; private set; } //read-only outside of the class
    public string _name;
    public string _address;
    public string _description;
    public string _phoneNumber;
    public Image _mainImage;
    //protected var locationVar; //placeholder if we decide to do anything with GoogleMaps
    public int _tableCount;
    public int availableTables;

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
            namePart = namePart.ToUpper();
        }
        else                                    //kitu atveju sugeneruoja random 3 raides
        {
            namePart = RandomTextString(3);
        }

        string numberPart = RandomNumberString(3);

        _searchCode = namePart + "-" + numberPart;
    }

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
}
