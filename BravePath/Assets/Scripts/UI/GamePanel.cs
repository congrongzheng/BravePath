using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePanel : MonoBehaviour
{
    [Header("Text")]
    public Text m_TxtScore;
    public Text m_TxtDiamondCount;

    [Header("Button")]
    public Button m_BtnPause;
    public Button m_BtnStart;


	// Use this for initialization
	void Start ()
    {
        m_BtnPause.onClick.AddListener(OnDealPause);
        m_BtnStart.onClick.AddListener(OnDealStart);
    }


    void OnDealPause()
    {

    }

    void OnDealStart()
    {

    }


}
