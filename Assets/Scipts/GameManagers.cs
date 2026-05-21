using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagers : MonoBehaviour
{
    public UIManager UIMgr;
    public float initialTime;
    // Start is called before the first frame update

    void Awake(){
        UIMgr = GameObject.FindObjectOfType<UIManager>();
    }
    void Start()
    {
        initialTime = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (initialTime > 0){
            initialTime = initialTime - Time.deltaTime;
        UIMgr.UpdateTime(initialTime);
        }
        else{
            UIMgr.UpdateTime(0);
            Debug.Log("Loss");
            Destroy(gameObject);
        }

    }
}
