using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTriggergeektroad : MonoBehaviour
{
    public GameObject player;
    public GameObject loadScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.Destroy(player);
            loadScreen.SetActive(true);
            StartCoroutine(Timer());
            
        }

    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("Scene 2");
    }
}
