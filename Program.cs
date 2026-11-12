using System.Globalization;
using TeniszpalyaFoglalas;
List<Foglalas> adatok=new List<Foglalas>();
Console.WriteLine("Adatok beolvasása a foglalasok.txt fájlból...\n");
foreach(string sor in File.ReadAllLines("foglalasok.txt"))
{
    adatok.Add(new Foglalas(sor));
}
Console.WriteLine("Napi pályafoglalások:");
foreach(Foglalas aktualis in adatok)
{
    Console.WriteLine(aktualis);
}
Console.WriteLine("");
Foglalas legjobb = adatok.MaxBy(x => x.FoglaltOrak);
Console.WriteLine("Statisztika:");
Console.WriteLine($"Teniszcentrum teljes napi bevétele: {adatok.Sum(x=> x.FizetendoDij())} Ft");
Console.WriteLine($"Legtöbb órát foglaló játékos: {legjobb.JatekosNev} ({legjobb.FoglaltOrak} óra)");