using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DialogueControl : MonoBehaviour
{
    public List<string> dialogue = new List<string>();
    public int dialogueLine;
    public TMP_Text myText;



    void Start()
    {
        dialogueLine = 0;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            dialogueLine ++;
        myText.text = dialogue[dialogueLine];
    }
  
  
        
  
    

}
   