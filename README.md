# cafe-demo

**Šiuo momentu kavinė atrodo taip:**

    public string _searchCode { get; } //read-only outside the class
    public string _name;
    public string _address;
    public string _description;
    public string _phoneNumber;
    public Image _mainImage;
    public int _tableCount;
    public int availableTables; //a.k.a. free tables

    public Kavine(string name, string address, int tableCount)
    {
        //TODO add checking if string != "", tableCount > 0
        _name = name;
        _address = address;
        _tableCount = tableCount;
        //_mainImage = some stock image
        GenerateAndSet_searchCode();
    }

GenerateAndSet_searchCode(); sugeneruoja "[3raides]-[3skaiciai]" kodą (pvz: DEX-201) 
