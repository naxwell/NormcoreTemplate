using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormcoreSwapHead : MonoBehaviour
{
    public string objectName;

    public GameObject[] clapperObjects;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in clapperObjects)
        {
            obj.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("head"))
        {
            other.GetComponent<MeshRenderer>().enabled = false;

            foreach (Transform child in other.transform)
            {
                if (child.gameObject.name == objectName)
                {
                    child.gameObject.SetActive(true);
                }
                else child.gameObject.SetActive(false);
            }

            if(objectName == "Clapper")
            {
                foreach(GameObject obj in clapperObjects)
                {
                    obj.SetActive(true);
                    
                }
            }
        }

    }
}
