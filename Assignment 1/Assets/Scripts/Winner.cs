using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Winner : MonoBehaviour
{
    public Text myText;
    public bool texting=false;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (texting)
        {
            myText.text = " YOU WON";
        }
        
    }

    private void OnCollisionEnter(Collision other)
    {
       
        Movement win = other.gameObject.GetComponent<Movement>();
        if (win)
        {
            texting = true;
            Debug.Log("WINNIG");
        }
    }

}
