//string[] isimler = new string[] {"Mete", "Samet", "Doğukan", "Yahya"};
//Console.WriteLine(isimler[0]);
//Console.WriteLine(isimler[1]);
//Console.WriteLine(isimler[2]);
//Console.WriteLine(isimler[3]);
//isimler = new string[5];
//isimler[4] = "Tayfun";
//Console.WriteLine(isimler[4]);
//Console.WriteLine(isimler[0]);


// Koleksiyonlarda değerleri kaybetmemizi engelleyecek bir alt yapı vardır.

List<string> isimler2 = new List<string> { "Mete", "Samet", "Doğukan", "Yahya" };
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);
isimler2.Add("İlker");
Console.WriteLine(isimler2[4]);
Console.WriteLine(isimler2[0]);