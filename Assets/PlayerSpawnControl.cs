using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnControl : MonoBehaviour
{
    public GameObject playerSpawn;
    public GameObject camera2;
    public GameObject player;
    public CameraTrigger camtrigger;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (camtrigger.scene2 == true);
        {
            player.transform.position = this.transform.position;
            Destroy(this);
        }

    }
}
