int sayi1 = 10;
int sayi2 = 30;
sayi1 = sayi2;
sayi2 = 65;
// sayi1 = ? --- 30

int[] sayilar1 = new int[] { 10, 20, 30 };
int[] sayilar2 = new int[] { 100, 200, 300 };
sayilar1 = sayilar2;
sayilar2[0] = 999;
            //sayilar1[0] = ? --- 999 


            // Değer Tip: int, decimal, float, double, bool
            // Referans Tip: array, class, interface

            // Bellekte "STACK" ve "HEAP" adında iki alan vardır.
            // Stack: 11. satırda sayı1'in değeri eşittir sayı 2'nin değeri olarak okunur. Sadece değeri aktarırsın ve sayı 2 ile olan bütün irtibatın orada kopar. Bu sebeple cevap 30.
            // Heap: 15. satırda 'int[] sayilar1' kısmı stack'de yer alır. 'new' dediğimiz anda sayilar1 için heap'de yeni bir alan oluştur ve değerleri oraya yaz demek.
            //          17. satırda sayilar1'in referans numarası sayilar2'nin referans numarasına eşittir demektir. Yani artık sayilar1, sayilar2 dizisiyle aynıdır. Bu sebeple cevap 999.
        