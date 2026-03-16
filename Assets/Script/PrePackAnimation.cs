using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrePackAnimation : MonoBehaviour
{
    public GameObject aanimation;
    public GameObject loop;
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
        yield return new WaitForSeconds(1.8f);
        aanimation.SetActive(false);
        loop.SetActive(true);

    }
}
