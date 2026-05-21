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
        initialTime = 30;
    }

    // Update is called once per frame
    void Update()
    {
        initialTime = initialTime - Time.deltaTime;
        UIMgr.UpdateTime(initialTime);

    }
}
