using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public Button button;
    public GameObject loadScreen;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        
        StartCoroutine(Timer());

    }
    IEnumerator Timer()
    {
        loadScreen.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Scene 0");
    }
}
