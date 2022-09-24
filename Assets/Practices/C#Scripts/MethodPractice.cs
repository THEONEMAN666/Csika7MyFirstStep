
using UnityEngine;

public class MethodPractice : MonoBehaviour
{

    [SerializeField] float number, number2;

    [SerializeField] float absNumber;
    [SerializeField] float signOfNumber;
    [SerializeField] float min, max;


    void OnValidate()
    {
        // Debug.Log("valamivalami");

        absNumber = Abs(number); // abszol�t�rt�k f�gv�ny
        signOfNumber = Sign(number);

        min = Min(number, number2);
        max = Mathf.Max(number, number2);
    }

    float Abs(float n) //saj�t met�dust hozunk l�tre
    {
        if (n < 0)
            n *= -1;
        return n;
    }

    float Sign(float n)
    {
      if(n < 0)
                return -1;
        else
            return 1; 
    }

    float Min(float a, float b)

    {
        if (a < b)
            return a;
        else // elhagyhat�
            return b;
    }
}
