using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Market : MonoBehaviour

{
    

    public int value;
    
    
    public TextMeshProUGUI priceTxt;
    
    // Start is called before the first frame update
    
    void Start()
    {
      
    }
    void  Update(){
        

       
    value = Mathf.RoundToInt(10*MathF.Sin(0.2f*Time.time)+10);
            
        
        priceTxt.text = value.ToString();
    }

    

   
}
