using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Transition2 : MonoBehaviour
{
    public Button button;
    public GameObject Door;
    public GameObject loadScreen;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        
    }
    void TaskOnClick()
    {
        StartCoroutine(Timer());
        
    }
    IEnumerator Timer()
    {
        loadScreen.SetActive(true);
        Door.SetActive(true);
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("Scene 3");
    }
}