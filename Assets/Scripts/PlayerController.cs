using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class PlayerController : MonoBehaviour
    {

        public float RollTime;
        private float rollTime;
        public float rollBoost = 2f;
        public float SPDMV;
        bool rollonce = false;
        public float moveSpeed = 5;
        private Rigidbody2D rb;
        public Vector3 moveInput;


        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();

        }
        private void Update()
        {

            // controller
            moveInput.x = Input.GetAxis("Horizontal");
            moveInput.y = Input.GetAxis("Vertical");
            transform.position += moveInput * moveSpeed * Time.deltaTime;
            //animation roll

            // dodge roll
            if (Input.GetKeyDown(KeyCode.Space) && rollTime <= 0)
            {

                rollTime = RollTime;
                moveSpeed += rollBoost;
                rollonce = true;

            }
            if (rollTime <= 0 && rollonce == true)
            {

                moveSpeed -= rollBoost;
                rollonce = false;

            }
            else
            {
                rollTime -= Time.deltaTime;
            }

            //auto fix rotation player


            Quaternion autofixdegree = Quaternion.Euler(0, 0, 0);
            transform.rotation = autofixdegree;
        
    }
   
}
