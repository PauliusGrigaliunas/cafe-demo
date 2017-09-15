# cafe-demo

**Šiuo momentu kavinė atrodo taip:**

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
        //TODO add checking if string != "", tableCount > 0
        _name = name;
        _address = address;
        _tableCount = tableCount;
        //_mainImage = some stock image
        GenerateAndSet_searchCode();
    }
