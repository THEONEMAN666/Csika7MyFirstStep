
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    /*a void Start() egy met�dus,
     l�tezik t�bb is de m�g csak ezt vett�k,
    ez a program bel�p�si pontja, a Start 
    automatikusan lefuttatja a akapcsos z�r�jelen bel�lit,
    ami a met�dus t�rzse
     */
    private void Start()
    {
        Debug.Log("HelloWorld"); //ez a parancs �rja ki a z�r�jelen bel�li r�szt
        Debug.Log("Sziasztok");
        Debug.Log($"My name is {name}");
    }
    /*Ebben az esetben egy komponens 
      nem csak a Hello Word sz�vegetfogja ki�rni, 
      hanem be is mutatkozik.*/
}

