using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SoundEffects : MonoBehaviour
{
    public Library myLibrary;
   
    public AudioSource audioSource;
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        myLibrary = FindObjectOfType<Library>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }




 
    public void playClip(){
        if(myLibrary.effectsActive){
        audioSource.clip = audioClip;
        audioSource.Play();
        }
    }
    
}
