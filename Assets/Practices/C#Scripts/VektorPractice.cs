
using UnityEngine;

public class VektorPractice : MonoBehaviour
{ // ctrl + r megv�ltoztatom a nev�t ctrl +d duplik�l, Ctrl + k+d be rendez mindent

    [SerializeField] Vector2 myFirst2DVector;
    [SerializeField] Vector3 myFirst3DVector;

    [SerializeField] Vector2 summ;
    [SerializeField] Vector3 diff;
    [SerializeField] Vector3 product;

    void OnValidate()

    {
        Vector2 v2a = new Vector2(); // (0,0)
        Vector2 v2b = new Vector2(2.33f, 3f); // (2.3, 3)
        Vector3 v3a = new Vector2(2.33f, 3f); //2.3 3 , 0
        Vector3 v3b = new Vector3(2.33f, 3f, 2); // (2.33, 3, 2)
        Vector3 v3c = new Vector3(); //(0,0,0)

        Vector3 v3d = Vector3.up;  // 0, 1, 0 
        Vector3 v3e = Vector3.back; // 0,0,-1


        Vector3 v3f = Vector3.zero; // 0,0,0
        Vector3 v3g = Vector3.one; // 1,1,1

        // M�veletek

        summ = new Vector2(1,2) + v2b; //obektom �sszead�s azaz vekrtor �sszead�s
        diff = (Vector3)myFirst2DVector - myFirst3DVector;
        product = 2 * myFirst3DVector;

        float leinght = v3b.magnitude;

        Vector3 normalized = v3b.normalized; // normaliz�lt v�ltoz�ja
        v3b.Normalize();
    }
}
