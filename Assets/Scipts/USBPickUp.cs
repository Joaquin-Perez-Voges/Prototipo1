using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USBPickUp : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        if(other.gameObject.CompareTag("Pickable"))
        {
            Destroy(other.gameObject);
        }
    }   
}