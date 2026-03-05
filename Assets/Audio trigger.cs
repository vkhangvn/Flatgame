using Fungus;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Audiotrigger : MonoBehaviour
{
    public GameObject SoundEffect;
    public GameObject PeopleNoise;

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
        yield return new WaitForSeconds(0.5f);
        SoundEffect.SetActive(true);
        yield return new WaitForSeconds(3f);
        PeopleNoise.SetActive(true);
    }
}
