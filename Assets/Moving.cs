using UnityEngine;

public class Moving : MonoBehaviour
{
    Vector3 target = new Vector3 (14, 1.5f, 0);
    void Update()
    {
        //1.MoveTowards 단순 등속
        /*transform.position =
            Vector3.MoveTowards(transform.position, 
            target, 1f);*/

        //2.SmoothDamp 감속하며 운동
        /*Vector3 velo = Vector3.zero;
        transform.position =
           Vector3.SmoothDamp(transform.position,
           target, ref velo, 0.1f);4
        */

        //3. Lerp (선형보간)
        /*transform.position =
           Vector3.Lerp(transform.position,
                        target, 0.05f);*/

        //4.Slerp (구면 선형보간)
        transform.position =
           Vector3.Slerp(transform.position,
                        target, 0.05f);
    }
}
