
    Kurs kurs1 = new Kurs();
    kurs1.KursAdi = "C#";
    kurs1.KursEgitmeni = "Engin Demiroğ";
    kurs1.IzlenmeOrani = 68;

    Kurs kurs2 = new Kurs();
    kurs2.KursAdi = "Java";
    kurs2.KursEgitmeni = "İlker Furkan Şahin";
    kurs2.IzlenmeOrani = 75;

    Kurs kurs3 = new Kurs();
    kurs3.KursAdi = "Python";
    kurs3.KursEgitmeni = "Mete Kayacan";
    kurs3.IzlenmeOrani = 89;

    Console.WriteLine(kurs1.KursAdi + ": " + kurs1.KursEgitmeni);
    Console.WriteLine(kurs2.KursAdi + ": " + kurs2.KursEgitmeni);

    Console.WriteLine("--- Dinamik hali ---");

    Kurs[] kurslar = new Kurs[]
    {
                kurs1, kurs2, kurs3
    };

    foreach (var kurs in kurslar)
    {
        Console.WriteLine(kurs.KursAdi + ": " + kurs.KursEgitmeni);
    }



class Kurs
{
    public string KursAdi { get; set; }
    public string KursEgitmeni { get; set; }
    public int IzlenmeOrani { get; set; }

}