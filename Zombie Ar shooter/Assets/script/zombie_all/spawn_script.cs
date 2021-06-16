using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_script : MonoBehaviour
{
    public Transform[] spawn_point;
    public GameObject[] obect_toSpawn;



    void Start()
    {
        StartCoroutine(StartSpawn());

    }
    IEnumerator StartSpawn()
    {
        yield return new WaitForSeconds(1);

        for(int i = 0;i < 1; i++)
        {
            Instantiate(obect_toSpawn[1], spawn_point[0].position, Quaternion.identity);
        }

        yield return new WaitForSeconds(1);

        for (int i = 0; i < 1; i++)
        {
            Instantiate(obect_toSpawn[0], spawn_point[0].position, Quaternion.identity);
        }

        StartCoroutine(StartSpawn());
    }
}
