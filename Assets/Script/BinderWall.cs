using Fungus;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BinderWall : MonoBehaviour
{

    public GameObject damageScene;
    public GameObject player;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            damageScene.SetActive(true);
            player.SetActive(false);
            StartCoroutine(Timer());
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("Scene 5");
    }

}