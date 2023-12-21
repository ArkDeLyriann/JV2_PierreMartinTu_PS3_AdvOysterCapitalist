using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellButton : MonoBehaviour
{
   public Library myLibrary;
   public Market myMarket;

    public int value;
    private int money;
    // Start is called before the first frame update
    
    void Start()
    {
        myMarket = FindObjectOfType<Market>();
        myLibrary = FindObjectOfType<Library>();
        
    }

    void Update(){
        money = myLibrary.money;
        value = myMarket.value;
    }


    public void SellOysters(){
        if(myLibrary.GetOyster()>0){
             
             money += value*myLibrary.GetOyster();

             myLibrary.SetOyster(0);
             
             myLibrary.money = money;
        }

    }
}
