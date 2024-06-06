using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dortİslem : MonoBehaviour
{
    public Text ilkSayi, ikinciSayi,islem,cevap, dy;
    int sayi1, sayi2, islemIsareti;
    int islemSonucu;
    // Start is called before the first frame update
    void Start()
    {
        sayi1 = Random.Range(1, 10);
        sayi2 = Random.Range(1, 10);
        islemIsareti = Random.Range(1, 5);

        switch (islemIsareti)
        {
            case 1:
                islem.text = "+";
                islemSonucu = sayi1 + sayi2;
                break;
            case 2:
                islem.text = "-";
                islemSonucu = sayi1 - sayi2;
                break;
            case 3:
                islem.text = "x";
                islemSonucu = sayi1 * sayi2;
                break;
            case 4:
                islem.text = "/";
                islemSonucu = sayi1 / sayi2;
                break;
        }
        ilkSayi.text = sayi1 + "";
        ikinciSayi.text = sayi2 + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cevapKontrol()
    {
        if (int.Parse(cevap.text) == islemSonucu)
        {
            dy.text = "Doğru";
        }
        else
        {
            dy.text = "Yanlış";
        }
    }
    public void yeniSoru()
    {
        cevap.text = "";
        dy.text = "";
        Start();
        
    }
}
