using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{

public TextMeshProUGUI txt_Score;
public TextMeshProUGUI txt_Time;
public TextMeshProUGUI txt_WinOrLose;
public Canvas panel_WorL;


    // Start is called before the first frame update
    void Start()
    {
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore(int score){
        txt_Score.text = "Score: " + score.ToString();
    }
    public void UpdateTime(float time){
        txt_Time.text = "Time: " + time.ToString("F2");
    }
    public void WinORLosePanel(bool win, bool show){

        panel_WorL.gameObject.SetActive(show);
        
        if (win){
        txt_WinOrLose.text = "Ganaste! \n Apreta R para Reiniciar"; 
        }
        if (!win){
            txt_WinOrLose.text = "Perdiste! \n Apreta R para Reiniciar"; 
        }
    }
    
}
