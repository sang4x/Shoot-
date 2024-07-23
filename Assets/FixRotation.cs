using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixRotation : MonoBehaviour
{
    private float timefix=0.3f;
    public Vector2 Timef1;
    public float time;
    public Vector2 Timef2;
    private Vector2 transfix1;
    private Vector2 transfix2;

    private void Update()
    {
        timefix -= Time.deltaTime;
        if (timefix >= 0.2)
        {
            
            Timef1 = transfix1;
            transfix1 = transform.position;
        }
      if (timefix <= 0)
       {
            Timef2 = transfix2;
            transfix2 = transform.position;
            timefix = 0.3f;
            if ((transfix1.x - transfix2.x)!= 0)
            {
                if ((transfix1.x - transfix2.x) < 0)
                {
                    transform.localScale =new Vector3 ((float)6.03, (float)6.03, (float)6.03);
                }
                else
                {
                    transform.localScale = new Vector3((float)-6.03, (float)6.03, (float)6.03);
                }
            }
          
       }
   
    }
}
