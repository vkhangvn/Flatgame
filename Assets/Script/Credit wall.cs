using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Numerics;

public class Creditwall : MonoBehaviour
{

    public GameObject crashScene;
    public GameObject player;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            crashScene.SetActive(true);
            StartCoroutine(Timer());
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("Main menu");
    }

}
