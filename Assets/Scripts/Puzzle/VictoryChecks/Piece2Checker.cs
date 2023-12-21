using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece2Checker : MonoBehaviour
{
    public GameObject piece;
    public bool isPlaced = false;
    public Transform pieceTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision collider)
    {
        if (collider.gameObject.tag == "Slot2"){
            pieceTransform.position =new Vector3(-1, -2, 0);
            piece.GetComponent<BoxCollider>().enabled = false;
            isPlaced = true;
        }
    }
}
