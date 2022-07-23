﻿List<string> sehirler = new List<string>();
sehirler.Add("Bilecik");
sehirler.Add("İstanbul");
sehirler.Add("Kocaeli");
sehirler.Add("Bursa");
Console.WriteLine(sehirler.Count);

MyList<string> sehirler2 = new MyList<string>();
sehirler2.Add("Ardahan");
sehirler2.Add("Yalova");
sehirler2.Add("Çanakkale");
sehirler2.Add("Ankara");
sehirler2.Add("Mardin");
Console.WriteLine(sehirler2.Count);




class MyList<T> //Generic class
{
    T[] _array;
    T[] _tempArray;
    public MyList()
    {
        _array = new T[0];
    }
    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_array.Length +1];
        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_array.Length - 1] = item;
    }


    public int Count
    {
        get { return _array.Length; }
    }

}