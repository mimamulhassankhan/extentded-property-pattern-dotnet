PersonModel p = new();

if (p is { firstName: "Imamul", address.home.village: "Fazilpur"})
{
    Console.WriteLine("Hello Imamul Hassan");
    Console.ReadKey();
}

class PersonModel
{
    public string firstName { get; set; } = "Imamul";
    public string lastName { get; set; } = "Hassan";
    public AddressModel address { get; set; } = new AddressModel();
}

class AddressModel
{
    public string city { get; set; } = "Dhaka";
    public string state { get; set; } = "Dhaka Division";
    public HomeModel home { get; set; } = new HomeModel();
}

class HomeModel
{
    public string village { get; set; } = "Fazilpur";
}
