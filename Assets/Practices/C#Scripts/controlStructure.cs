
using UnityEngine;

public class controlStructure : MonoBehaviour
{
    [SerializeField] int number;

    void Start()
    {

        bool isEven = number % 2 == 0;

        if (isEven)
        {
            Debug.Log("P�ros");

        }

        else //egy�bk�nt
        {
            Debug.Log("P�ratlan");
        }

        //-------------------------------------

        if (number >= 1)

        {
            Debug.Log("Positive");
        }

        else if (number <= -1) //egy�bk�nt ha

        {
            Debug.Log("negative");
        }
        else
        {
            Debug.Log("Zero");
        }

        //Loop-------------------------------------


        int i = 1;

        while (i < number)
        {
            Debug.Log(i);
            i++;
        }

        //For Loop-------------------------------------

        for (int j = 1; j <= number; j++)
        {
            Debug.Log(j);
        }
    }

}
