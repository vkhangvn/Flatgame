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
    public Flowchart flowchart;
    public string blockName;

    // Start is called before the first frame update
    void OnTriggerStay2D(Collider2D other)
    {
        {
            if (other.CompareTag("Player"))
            {
                player.position = Vector2.MoveTowards(player.position,slot.transform.position, 8 * Time.deltaTime);
                StartCoroutine(Timer());
                arrow.SetActive(false);
                flowchart.ExecuteBlock(blockName);

            }
        }
    }
    IEnumerator Timer()
    {
        player1.SetActive(false);
        fezan.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scene 6");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
