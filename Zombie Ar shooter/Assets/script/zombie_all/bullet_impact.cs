using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_impact : MonoBehaviour
{
    public string color_choose;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == color_choose)
        {
            coin_counter.coincounter += 1;
            Destroy(gameObject);
            Destroy(col.gameObject);
        }

        else
            Destroy(gameObject);


    }
}
