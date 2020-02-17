using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject bulletprefab;
    public float shootSpeed = 200;

    

    void Start()
    {
       // mousePos = Input.mousePosition;
       // mousePos += Camera.main.transform.forward * 10f; // Make sure to add some "depth" to the screen point 
        //aim = Camera.main.ScreenToWorldPoint(mousePos);
    }

    void Update()
    {
        //aim = Camera.main.ScreenToWorldPoint(mousePos)
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Debug.Log("Mouse 0 _left");
            shootBullet();

        }
    }
        void shootBullet()
        {
            GameObject shot = GameObject.Instantiate(bulletprefab, transform.position+(transform.forward *8), Quaternion.identity);
            shot.GetComponent<Rigidbody>().AddForce(transform.forward * shootSpeed);
        }

}

