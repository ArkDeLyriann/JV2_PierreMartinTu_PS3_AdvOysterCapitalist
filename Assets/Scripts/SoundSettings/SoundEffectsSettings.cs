using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsSettings : MonoBehaviour
{
   public Library myLibrary;

    public GameObject tickPanel;
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
    public void SoundEffectsOff(){
        myLibrary.effectsActive = !myLibrary.effectsActive;
    }
}
