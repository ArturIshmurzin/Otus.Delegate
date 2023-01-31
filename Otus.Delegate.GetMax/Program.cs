using OTUS.Delegate.GetMax;

List<Country> countries= new List<Country>();

Random random= new Random();

for (int i = 0; i < 10; i++)
{
    countries.Add(new()
    {
        Number = i,
        Population = random.Next(1000),
        Square = random.Next(10000),
    });
}

Console.WriteLine(countries.GetMax(PopulationService.GetPopulationDensity)!.Number);
Console.ReadKey();
