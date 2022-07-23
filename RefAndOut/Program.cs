//C# içerisinde yer alan ref ve out anahtar kelimeleri aynı işlemi yapar.
//Ancak ref ile kullanımda değişkene başlangıç değerinin verilmesi gerekirken out anahtar kelimesi ile kullanımda başlangıç değerinin verilmesine gerek yoktur.

int sayimizRef = 0;  // değer verilmediğinde hata verecektir.
DegistirRef(ref sayimizRef);
Console.WriteLine(sayimizRef);

int sayimizOut;
DegistirOut(out sayimizOut);
Console.WriteLine(sayimizOut);

static void DegistirRef(ref int sayiRef)
{
    sayiRef = 1234;
}

static void DegistirOut(out int sayiOut)
{
    sayiOut = 1234;
}