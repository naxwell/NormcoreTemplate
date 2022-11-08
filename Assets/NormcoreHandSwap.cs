using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormcoreHandSwap : MonoBehaviour
{
    public string objectName; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void OnTriggerEnter(Collider other) {
    if(other.CompareTag("hand")){
        other.GetComponent<MeshRenderer>().enabled = false; 

        foreach (Transform child in other.transform)
        {
            if(child.gameObject.name == objectName){
                child.gameObject.SetActive(true);
            } else child.gameObject.SetActive(false); 
        }
    }
   }
}
