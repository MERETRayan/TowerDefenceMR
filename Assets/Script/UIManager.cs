using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public static UIManager instance { get; set; } = null;

    public Text _timerText = null;
    private Text timerText { get { return _timerText ; } }

    public Text _goldText = null;
    private Text goldText { get { return _goldText; } }

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetTimer(float timer)
    {
        timerText.text = "Timer : " + timer.ToString("F0") + " s";
    }

    public void SetGold(float gold)
    {
        goldText.text = "Gold : " + gold  ;
    }
}
