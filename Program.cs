using System.Globalization;
using TeniszpalyaFoglalas;
List<Foglalas> adatok=new List<Foglalas>();
foreach(string sor in File.ReadAllLines("foglalasok.txt"))
{
    adatok.Add(new Foglalas(sor));
}
