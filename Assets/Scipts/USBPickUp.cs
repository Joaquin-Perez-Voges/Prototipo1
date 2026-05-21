using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USBPickUp : MonoBehaviour
{
    int contadorPuntos = 0;
    public UIManager UIMgr;

    void Awake(){
        UIMgr = GameObject.FindObjectOfType<UIManager>();
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        if(other.gameObject.CompareTag("Pickable"))
        {
            contadorPuntos++;
            Destroy(other.gameObject);
            UIMgr.UpdateScore(contadorPuntos);
        }
    }   
}