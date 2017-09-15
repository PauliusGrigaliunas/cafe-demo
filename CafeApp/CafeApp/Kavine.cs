using System;
using System.Drawing.Image;

public class Kavine
{
    protected string _name;
    protected string _searchCode;
    protected string _address;
    protected string _description;
    protected string _phoneNumber;
    protected Image _mainImage;
    //protected var locationVar; //placeholder if we decide to do anything with GoogleMaps
    protected int _tableCount;

    protected int availableTables;

    public Kavine(string name, string address, int tableCount)
    {
        _name = name;
        _address = address;
        _tableCount = tableCount;
        //_mainImage = some stock image
    }


}
