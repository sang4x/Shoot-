using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
   
    public Transform playerps;
    public GameObject bullet;
    private float timecountdown = 2f;
    public float spd;
    public float timebtwfire;
    private void Update()
    {
        timecountdown -= Time.deltaTime;
        if (timecountdown < 0)
        {
            firebulletAI();
            timecountdown = timebtwfire;
        }
        void firebulletAI()
        {
            var bullettmp = Instantiate(bullet, transform.position, Quaternion.identity);
            Rigidbody2D rb = bullettmp.GetComponent<Rigidbody2D>();
            Vector2 degfire = playerps.transform.position - transform.position;
            rb.AddForce(degfire.normalized * spd, ForceMode2D.Impulse);
        }
    }
}
