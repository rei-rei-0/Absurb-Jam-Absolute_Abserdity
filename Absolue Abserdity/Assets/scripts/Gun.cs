using UnityEngine;

public class Gun : MonoBehaviour
{
   //public float damage = 10f;
    public float range = 100f;
    //how far the raycast will reach
    public float fireRate = 1f;
    //if firerate is lower, the amount of bullet spawn time is long, smaller = limit

    

    public GameObject fpsCam;//reference the camera
    // Update is called once per frame
    public GameObject bullet;

    private float nextTimeToFire = 0f;
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= nextTimeToFire) //fire1 is unity's left click
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);//direction of where the camera is facing
            GameObject bulletGo = Instantiate(bullet, hit.point, Quaternion.identity);
            //add the bulletprefab
            Destroy(bulletGo, 1F);
        }
        //raycast is the same thing as hitscan
        //hitscan means there is no projecticle velocity, it is instantaneous
    }
}
