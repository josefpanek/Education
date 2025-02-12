class Package
{
    public string CompanyName { get; set; } = null!;
    
    public decimal Weight { get; set; }
    
    public string TrackingNumber { get; set; } = null!;
}

internal class Program
{
    public static void Main(string[] args)
    {
        List<Package> packages = new List<Package>
        {
            new Package {CompanyName = "PVT", Weight = 5.5m, TrackingNumber = "A5E123456"},
            new Package {CompanyName = "ABB", Weight = 0.3m, TrackingNumber = "A5E234567"},
            new Package {CompanyName = "IBM", Weight = 7.7m, TrackingNumber = "A5E345678"}
        };  

        Dictionary<string, Package> packagesByCompany = packages.ToDictionary(x => x.TrackingNumber);

        foreach (var package in packagesByCompany)
        {
            Console.WriteLine("{0} {1}", package.Value.CompanyName, package.Value.TrackingNumber);
        }
    }
}