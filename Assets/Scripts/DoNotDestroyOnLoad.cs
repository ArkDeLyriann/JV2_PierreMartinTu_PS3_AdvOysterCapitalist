using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroyOnLoad : MonoBehaviour
{

    public GameObject thisObject;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(thisObject);
    }
}
