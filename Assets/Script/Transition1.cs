using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Transition1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("Road to geeky");
    }
}
