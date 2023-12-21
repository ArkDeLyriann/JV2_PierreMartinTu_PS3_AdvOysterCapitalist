using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSettings : MonoBehaviour
{
    public Library myLibrary;

    public GameObject tickPanel;
    // Start is called before the first frame update
    void Start()
    {
        myLibrary = FindObjectOfType<Library>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void unTIck(){

    
    if (tickPanel != null) {
            bool isActive = tickPanel.activeSelf;
            tickPanel.SetActive(!isActive);
        
        }
    }

    public void MusicOff(){
        myLibrary.soundActive = !myLibrary.soundActive;
        
    }
}
