using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CardPlacedBinder : MonoBehaviour
{
    public Transform player;
    public GameObject player1;
    public GameObject fezan;
    public Transform slot;
    public GameObject arrow;

    // Start is called before the first frame update
    void OnTriggerStay2D(Collider2D other)
    {
        {
            if (other.CompareTag("Player"))
            {
                player.position = Vector2.MoveTowards(player.position,slot.transform.position, 8 * Time.deltaTime);
                StartCoroutine(Timer());
                arrow.SetActive(false);

            }
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.5f);
        player1.SetActive(false);
        fezan.SetActive(true);
        SceneManager.LoadScene("Scene 6");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
