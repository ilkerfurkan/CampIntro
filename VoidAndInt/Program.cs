class Program
{
    static void Main(string[] args)
    {
        Program productManager = new Program();

        //public void
        productManager.Topla2(3, 6);

        //public int: işlem yapılabilir.
        int toplamaSonucu = productManager.Topla(3, 6);
        Console.WriteLine(toplamaSonucu * 2);
    }
    public int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public void Topla2(int sayi1, int sayi2)
    {
        Console.WriteLine(sayi1 + sayi2);
    }
}