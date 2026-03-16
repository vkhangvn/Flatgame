using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pack2 : MonoBehaviour
{
    public GameObject cardObtain;
    public GameObject rareCard;
    public GameObject Packbattle2;
    // Start is called before the first frame update
    void update()
    {
        if (Packbattle2.activeInHierarchy)
            { 
            StartCoroutine(Timer());
            } 
    }

    // Update is called once per frame
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(3.8f);
        cardObtain.SetActive(true);
        yield return new WaitForSeconds(1.1f);
        cardObtain.SetActive(false);
        cardObtain.SetActive(true);
        yield return new WaitForSeconds(1.1f);
        cardObtain.SetActive(false);
        cardObtain.SetActive(true);
        yield return new WaitForSeconds(1.1f);
        cardObtain.SetActive(false);
        cardObtain.SetActive(true);
        yield return new WaitForSeconds(1.1f);
        rareCard.SetActive(true);
    }
}
