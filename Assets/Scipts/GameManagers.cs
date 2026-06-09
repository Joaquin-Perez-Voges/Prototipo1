using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagers : MonoBehaviour
{
    public UIManager UIMgr;
    public float initialTime;
    // Start is called before the first frame update

    void Awake(){
        UIMgr = GameObject.FindObjectOfType<UIManager>();
        UIMgr.WinORLosePanel(false, false);
    }
    void Start()
    {
        initialTime = 20;
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
            UIMgr.WinORLosePanel(false, true);

        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("reiniciando");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
