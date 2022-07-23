using GenericsIntro;

MyList<string> isimler = new MyList<string>();

isimler.Add("Ali");
Console.WriteLine(isimler.Length);

isimler.Add("Mert");
Console.WriteLine(isimler.Length);

foreach (var isim in isimler.Items)
{
    Console.WriteLine(isim);
}