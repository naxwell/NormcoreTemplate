using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handStartup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
