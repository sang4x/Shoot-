using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{


    Playerheath Players;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Players = collision.GetComponent<Playerheath>();
            Invoke("damgeplayer",0f);
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Players = null;
            CancelInvoke("damgeplayer");
            Destroy(this.gameObject);
        }
    }
    void damgeplayer()
    {
        Players.Takedamage(15);
    }
}


