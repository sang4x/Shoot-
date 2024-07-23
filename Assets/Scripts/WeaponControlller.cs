using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControlller : MonoBehaviour
{
    private float timest = 2f;
    public SpriteRenderer wps;
    public GameObject bullet;
    public float TimeBtwFire = 0.2f;
    public float BulletForce;
    private float timeBTWFire;
    public Transform firepos;
    public float a;
    private void Start()
    {
       
    }
    void Update()
    {
        timeBTWFire-= Time.deltaTime;
        if (Input.GetMouseButton(0) && timeBTWFire <0)   
        {
            Firebullet();
        }
        Rotations();
       
    }
    void Firebullet()
    {
        timeBTWFire = TimeBtwFire;
        GameObject bullettmp = Instantiate(bullet,firepos.position,Quaternion.identity);
        if (timest <= 0)
        {
            Destroy(bullettmp);
        }
        Rigidbody2D rb = bullettmp.GetComponent<Rigidbody2D>();
        rb.AddForce(wps.transform.right * BulletForce, ForceMode2D.Impulse);
    }
    private void Rotations()
    {

        Vector3 mousepos =UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookdir = mousepos - wps.transform.position;
        float angle = Mathf.Atan2(lookdir.y, lookdir.x)*Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.Euler(0, 0, angle);
        wps.transform.rotation = rotation;

        a = angle;
        if (wps.transform.eulerAngles.z > 90 && wps.transform.eulerAngles.z < 270) wps.transform.localScale = new Vector3(1,-1,0);
        else wps.transform.localScale = new Vector3(1, 1, 0);
    }
}
