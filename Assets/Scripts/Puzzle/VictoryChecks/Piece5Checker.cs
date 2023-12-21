using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece5Checker : MonoBehaviour
{
    public GameObject piece;
    public bool isPlaced= false;
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
        if (collider.gameObject.tag == "Slot5"){
            pieceTransform.position =new Vector3(-1, -2, 1);
            piece.GetComponent<BoxCollider>().enabled = false;
            isPlaced = true;
        }
    }
}