using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Playerheath Players;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Players = collision.GetComponent<Playerheath>();
            InvokeRepeating("damgeplayer",1f,1f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Players = null;
            CancelInvoke("damgeplayer");
        }
    }
    void damgeplayer()
    {
        Players.Takedamage(20);
    }
}
