using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Script : MonoBehaviour
{
    public GameObject Pause_Menu;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Resume()
    {
        //isPaused = false;
        Pause_Menu.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause_Menu.SetActive(!Pause_Menu.activeSelf);
        }
    }
}
