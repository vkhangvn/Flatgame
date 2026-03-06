using Fungus;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10f;
    public GameObject moveSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
            moveSound.SetActive(true);
        }
        if (Input.GetKey(KeyCode.S))

        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
            moveSound.SetActive(true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            moveSound.SetActive(true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            moveSound.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            moveSound.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            moveSound.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            moveSound.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            moveSound.SetActive(false);
        }
    }
}
