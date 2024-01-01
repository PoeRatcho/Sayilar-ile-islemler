using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class deneme : MonoBehaviour
{
    void BolenleriBul(int ilkSayi, int ikinciSayi)
    {

        //sýralý sayýlarým list ile iki ye üç e 4 e 5e bölünenleri listeledim
        List<int> siraliSayilar = new List<int>();
        List<int> ikiyeBolunen = new List<int>();
        List<int> uceBolunen = new List<int>();
        List<int> dordeBolunen = new List<int>();
        List<int> beseBolunen = new List<int>();


        //for döngüm  fonksiyondan aldýðý sayýlar 6 7 8 9 ... diye gidip 77 e yakar if ten çýkaracak bölünenleri.
        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            siraliSayilar.Add(i);

            //eðer  bölümlerim 

            if (i % 2 == 0)
                ikiyeBolunen.Add(i);
            if (i % 3 == 0)
                uceBolunen.Add(i);
            if (i % 4 == 0)
                dordeBolunen.Add(i);
            if (i % 5 == 0)
                beseBolunen.Add(i);
        }

        //print iþlemlerim. Yazýlar string - koymalý ve sýralama devam ediyor.
        print("Sýralý Sayýlar: " + string.Join("-", siraliSayilar));
        print("Ýkiye Bölünen Sayýlar: " + string.Join("-", ikiyeBolunen));
        print("Üçe Bölünen Sayýlar: " + string.Join("-", uceBolunen));
        print("Dörde Bölünen Sayýlar: " + string.Join("-", dordeBolunen));
        print("Beþe Bölünen Sayýlar: " + string.Join("-", beseBolunen));
    }

    public void Start()
    {

        //fonksiyonum.
        BolenleriBul(6, 77);

    }

}


