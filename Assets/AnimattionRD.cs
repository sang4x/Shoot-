using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimattionRD : MonoBehaviour
{
    public float RollTime1;
    private float rollTime1;
    bool rollonce = false;
    private Animator animator;
    private Vector3 movefix;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        movefix.x = Input.GetAxis("Horizontal");
        movefix.y = Input.GetAxis("Vertical");
        animator.SetFloat("SPDmove", movefix.sqrMagnitude);
        //fix scale player
        if (movefix.x != 0)
        {
            if (movefix.x > 0)
            {
                transform.localScale = new Vector3(1, 1, 0);
            }
            else
                transform.localScale = new Vector3(-1, 1, 0);
        }
        animator.SetBool("Roll", rollonce);
        if (Input.GetKeyDown(KeyCode.Space) && rollTime1 <= 0)
        {
            rollTime1 = RollTime1;
            rollonce = true;
        }
        if (rollTime1 <= 0 && rollonce == true)
        {
            rollonce = false;
        }
        else
        {
            rollTime1 -= Time.deltaTime;
        }
        Quaternion autofixdegree = Quaternion.Euler(0, 0, 0);
        transform.rotation = autofixdegree;
    }
}
