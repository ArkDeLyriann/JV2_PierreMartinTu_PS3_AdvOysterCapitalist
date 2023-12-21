using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductionOnTouch : MonoBehaviour
{
    public GameObject Panel;

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

    //Opens the buildings menu
    public void OnMouseDown()
    {
        if(myLibrary.effectsActive){
        playClip();
        }
        if (Panel != null) {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        
        }
    }

    public void playClip(){
        audioSource.clip = audioClip;
        audioSource.Play();
    }

  
}
