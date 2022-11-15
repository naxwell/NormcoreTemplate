using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerInputs : MonoBehaviour
{
    public GameObject Rig;
    public Vector3 big = new Vector3(2, 2, 2);
    public Vector3 small;

    bool growing = false;
    bool shrinking = false; 
    float t;
    public float speed = 1; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (growing)
        {
    
            float currentSize = Mathf.Lerp(1, 4, t);
            t += 0.1f * speed * Time.deltaTime;
            Rig.transform.localScale = new Vector3(currentSize, currentSize, currentSize);
        }

        if (shrinking)
        {
            float currentSize = Mathf.Lerp(4, 1, t);
            t += 0.2f * speed * Time.deltaTime;
            Rig.transform.localScale = new Vector3(currentSize, currentSize, currentSize);
        }
    }
    
    public void primaryButtonPress(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            
            Debug.Log("Button Pressed!");

        }
    }

    public void nonsenseFunction(InputAction.CallbackContext context)
    {
        if (context.canceled)
        {
            Debug.Log("nonsense has happened!");
        }
        
    }

    public void scaleUpPlayer(InputAction.CallbackContext context)
    {
        //Rig.transform.localScale = big;
        growing = true;
        shrinking = false;
        t = 0; 
    }

    public void scaleDownPlayer(InputAction.CallbackContext context)
    {
        //Rig.transform.localScale = small;
        growing = false;
        shrinking = true;
        t = 0;
    }


}
