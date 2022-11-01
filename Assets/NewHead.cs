using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit; 

public class NewHead : MonoBehaviour
{

    private Rigidbody rb; 
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
        if(other.gameObject.CompareTag("head")){
            GetComponent<XRGrabInteractable>().enabled = false;
            //Found the Hand
            Debug.Log("headed");
            //Move the new object to the hands position 
            transform.position = other.transform.position;
            Debug.Log(other.transform.rotation);
            Debug.Log(other.transform.localRotation);
            //make the object a child of the VR hand  
            //transform.SetParent(other.transform.parent);
            transform.parent = other.transform.parent;
            transform.localRotation = other.transform.localRotation;
            // turn off gravity, otherwise it will fall away from VR hand 
            rb.useGravity = false; 
            //give the new hand the correct tag so that it will be switchable in the future 
            gameObject.tag = "head"; 
            //make sure the collider is set to trigger or it wont be able to be switched in the future
            col.isTrigger = true; 
            //get rid of old hand 
            Destroy(other.gameObject);
            Destroy(this); 

        }
    
    }
}
