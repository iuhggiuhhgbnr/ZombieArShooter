using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin_counter : MonoBehaviour
{
    Text text;
    public static int coincounter;
    void Start()
    {
        text = GetComponent<Text>();
        coincounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = coincounter.ToString();
    }
}
