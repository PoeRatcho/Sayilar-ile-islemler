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

        //s�ral� say�lar�m list ile iki ye �� e 4 e 5e b�l�nenleri listeledim
        List<int> siraliSayilar = new List<int>();
        List<int> ikiyeBolunen = new List<int>();
        List<int> uceBolunen = new List<int>();
        List<int> dordeBolunen = new List<int>();
        List<int> beseBolunen = new List<int>();


        //for d�ng�m  fonksiyondan ald��� say�lar 6 7 8 9 ... diye gidip 77 e yakar if ten ��karacak b�l�nenleri.
        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            siraliSayilar.Add(i);

            //e�er  b�l�mlerim 

            if (i % 2 == 0)
                ikiyeBolunen.Add(i);
            if (i % 3 == 0)
                uceBolunen.Add(i);
            if (i % 4 == 0)
                dordeBolunen.Add(i);
            if (i % 5 == 0)
                beseBolunen.Add(i);
        }

        //print i�lemlerim. Yaz�lar string - koymal� ve s�ralama devam ediyor.
        print("S�ral� Say�lar: " + string.Join("-", siraliSayilar));
        print("�kiye B�l�nen Say�lar: " + string.Join("-", ikiyeBolunen));
        print("��e B�l�nen Say�lar: " + string.Join("-", uceBolunen));
        print("D�rde B�l�nen Say�lar: " + string.Join("-", dordeBolunen));
        print("Be�e B�l�nen Say�lar: " + string.Join("-", beseBolunen));
    }

    public void Start()
    {

        //fonksiyonum.
        BolenleriBul(6, 77);

    }

}


