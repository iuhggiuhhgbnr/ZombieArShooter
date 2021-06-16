using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_Dead : MonoBehaviour
{
    public GameObject Dead_panel;
    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "green")
        {
            Debug.Log("green hit you");
            Dead_panel.SetActive(true);
            Time.timeScale = 0;
        }

        if (target.tag == "orange")
        {
            Debug.Log("orange hit you");
            Dead_panel.SetActive(true);
            Time.timeScale = 0;
        }
    }


    public void OnRestartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void OnExitButton()
    {
        Time.timeScale = 1;
        Application.Quit();
    }
}
