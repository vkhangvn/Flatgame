using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool pause = false;

    // Start is called before the first frame update
    void Start()
    {
   

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause == true)
            {
                pause = false;
                pauseMenu.SetActive(false);
                Time.timeScale = 1f;
            }

            else
            {
                Time.timeScale = 0f;
                pause = true;
                pauseMenu.SetActive(true);
            }
        }



    }
}
