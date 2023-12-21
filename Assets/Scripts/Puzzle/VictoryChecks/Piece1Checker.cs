using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece1Checker : MonoBehaviour
{
    public GameObject piece;
    public bool isPlaced= false;
    public Transform pieceTransform;

    public Puzzle puzzle;
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
        if (collider.gameObject.tag == "Slot1"){
            pieceTransform.position =new Vector3(0, -2, 0);
            piece.GetComponent<BoxCollider>().enabled = false;
            isPlaced = true;
            //puzzle.correctlyPlacedPiece;
        }
    }
}
