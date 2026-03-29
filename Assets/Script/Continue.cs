using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Continue : MonoBehaviour
{
    public Button button;
    public Pause script;
    public GameObject pauseMenu;
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        script.pause = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
