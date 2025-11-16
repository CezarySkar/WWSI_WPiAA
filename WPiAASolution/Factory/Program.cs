using Factory;

var garnizon = new Garnizon();
List<Wojownik> wojsko = new List<Wojownik>();

for(int i = 0; i< 3; i++)
{
    wojsko.Add(garnizon.Train("piechur", $"Piechur_{i + 1}"));
}

for (int i = 0; i < 3; i++)
{
    wojsko.Add(garnizon.Train("konny", $"Konny_{i + 1}"));
}

for (int i = 0; i < 4; i++)
{
    wojsko.Add(garnizon.Train("strzelec", $"Strzelec_{i + 1}"));
}

foreach (var wojownik in wojsko)
{
    wojownik.Attack();
}