using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PomonPack1 : MonoBehaviour
{
    public GameObject hit;
    public GameObject cutscene;
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
        yield return new WaitForSeconds(8.7f);
        hit.SetActive(true);
        cutscene.SetActive(false);
        
    }
}