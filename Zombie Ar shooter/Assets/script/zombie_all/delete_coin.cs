using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete_coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)     //Delte object  that touch it i mean trigger this
    {
        if (other.gameObject.tag == "green")
            Destroy(other.gameObject);
        if (other.gameObject.tag == "bullet_green")
            Destroy(other.gameObject);
        if (other.gameObject.tag == "bullet_orange")
            Destroy(other.gameObject);
    }
}
