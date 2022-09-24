
using UnityEngine;

public class KommentsAndVariables : MonoBehaviour
{
    private void Start()

    //----KOMMENTEK FAJT�I----

    //sorv�gi komment
    /*k�t sor k�z�tti komment*/
    /*Megbontott
     T�bb soros komment*/

    {
        //----Variables=V�ltoz�k----

        /*V�ltoz�k programoz�si elemek, 
          amiket szabadon hozhatunk l�tre 
          k�dunk �r�sa k�zben*/

        int egeszSzam; // Deklarate
        egeszSzam = 5; // Definiation
        egeszSzam = 34; // Change value
        egeszSzam = 3324; // Change value
        Debug.Log(egeszSzam);

        int a = 3 + 5; // 8
        int b = a - 11; // -3
        int c = a * b; // -24
        int d = a / 3; // 2

        float f1 = 45.76f; // lebeg�pontos sz�mok, tizedest�rtek
        float f2 = 22, f3 = 32.4f, f4 = 45; //egy sorban is megadhat� az �rt�k, ilyenkor el�g vessz� k�z�

        float sum = f1 + f2;
        float difference = f1 - f2;
        float product = 1 * f2;
        float rate = f1 / f2;

        //----alap m�veletek vegyesen----

        int i = 10;
        float f = 2.5f;

        var summa = i + f; //float tipus �rt�k 12.5f
        var diff = i - f; // float tipus �rt�k 7.5f
        var prod = i * f; // float tipus �rt�k 25f
        var quotient = i / f; // float tipus �rt�k 4f

        //----Neg�l�s----

        int g = 6;
        float h = -77.7f;

        var gNeg = -i; // int tipus �rt�k:-6
        var hNeg = -77.7f; // float tipus �rt�k 77.7

        //----Modulo----

        int rateInt = 11 / 3; // 3 mivel az int lev�gja a tizedest csak ekrek �rt�ket ad
        int moduloInt = 1 % 3; // 2 mivel a %-jeles oszt�s a maradv�ny �rt�ket jelen�ti meg

        float q2 = 63.5f / 10f; // eredm�ny 6.35
        float m2 = 63.5f % 10f; // erdm�ny 3.5 modulot ugyan�gy alkalmazza floaton is de nem csapja le a tizedest

        //----Kasztol�s----

        float fff = 5; // Implicit casting azaz tizedest�rt eg�ssz� alak�t floatb�l int lesz
        int iii = (int) 5.5f; // explicit casting a fenti ford�totja

        //----R�vid Forma----

        a = a + 5;
        a += 5; //ez a fentebbi sor r�vid�tve

        a = a - 5;
        a -= 5;

        a = a * 5;
        a *= 5;

        a = a / 5;
        a /= 5;


        /* prefixes r�vid�t�s*/

        ++a; //egyel n�veli az �rt�ket
        --a; // egyel cs�kkenti az �rt�ket

        /*postfixes r�vid�t�s*/

        a++;
        a--;
        /* A postfixes forma egy kicsit bonyolultabb, els�k�nt l�trehoz egy �tmeneti v�ltoz�t, amiben elt�rolja az
        operandusa �rt�k�t, majd megn�veli egyel az operandust, v�g�l visszaadja az �tmeneti v�ltoz�t.*/

        Debug.Log(a);

        // ... �s �gy tov�bb
    }
}
