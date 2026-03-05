using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class CameraTrigger : MonoBehaviour
{
    void Start()
    {
        camera2.SetActive(false);
        camera1.SetActive(false);
        camera0.SetActive(true);
    }
    
    public GameObject camera2;
    public bool scene2 = false;
    public GameObject playerspawn;
    public GameObject player;
    public GameObject camera0;
    public GameObject camera1;

    void OnTriggerStay2D(Collider2D other)
    {
        camera1.SetActive(false);
        camera2.SetActive(true);
        scene2 = true;
        player.transform.position = playerspawn.transform.position;
        Destroy(this);
    }

}
