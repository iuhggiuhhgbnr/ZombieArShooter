using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_script : MonoBehaviour
{
    public GameObject arCamera;

    public GameObject Bullet_1;
    public GameObject Bullet_2;

    public float Speed_Bullet = 500f;

    public void Shoot()          //not use this function any more  it a ray cast
    {
        RaycastHit hit;
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.tag == "Player")
            {
                coin_counter.coincounter += 1;
                //sound.Play();
                Destroy(hit.transform.gameObject);
            }
        }
    }

    public void ShootBullet1()
    {
        GameObject intsBullet = Instantiate(Bullet_1, arCamera.transform.position, Quaternion.identity) as GameObject;
       // intsBullet.transform.position = arCamera.transform.forward ;
        intsBullet.transform.position = arCamera.transform.position;
        Rigidbody instBulletRigibody = intsBullet.GetComponent<Rigidbody>();
        instBulletRigibody.velocity = arCamera.transform.TransformDirection(Vector3.forward * Speed_Bullet * Time.deltaTime);
    }

    public void ShootBullet2()
    {
        GameObject intsBullet = Instantiate(Bullet_2, arCamera.transform.position, Quaternion.identity) as GameObject;
        // intsBullet.transform.position = arCamera.transform.forward ;
        intsBullet.transform.position = arCamera.transform.position;
        Rigidbody instBulletRigibody = intsBullet.GetComponent<Rigidbody>();
        instBulletRigibody.velocity = arCamera.transform.TransformDirection(Vector3.forward * Speed_Bullet * Time.deltaTime);
    }



}
