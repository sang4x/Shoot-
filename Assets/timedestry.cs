using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timedestry : MonoBehaviour
{
    public float timedestroy=2f;
    private void Update()
    {
        timedestroy -= Time.deltaTime;
        if (timedestroy <= 0)
        {
            Destroy(this.gameObject, timedestroy);
        }
    }
}
