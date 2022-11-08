using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]

public class newHand : MonoBehaviour
{

    public Rigidbody rb; 
    private Collider col; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        col = GetComponent<Collider>();

 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("hand")){
            //Found the Hand
            Debug.Log("handed");
            //Move the new object to the hands position 
            transform.position = other.transform.position;
            Debug.Log(other.transform.rotation);
            Debug.Log(other.transform.localRotation);
            //make the object a child of the VR hand  
            //transform.SetParent(other.transform.parent); << functions the same as below as far as i can tell 
            transform.parent = other.transform.parent;
            
            transform.localRotation = other.transform.localRotation;
            // turn off gravity, otherwise it will fall away from VR hand 
            rb.useGravity = false; 
            //give the new hand the correct tag so that it will be switchable in the future 
            gameObject.tag = "hand"; 
            //make sure the collider is set to trigger or it wont be able to be switched in the future
            col.isTrigger = true; 
            //get rid of old hand 
            Destroy(other.gameObject);
            Destroy(this); 

        }
    
    }
}
