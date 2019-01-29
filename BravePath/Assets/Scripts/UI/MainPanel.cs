using UnityEngine;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
    public Button m_BtnStart;
    public Button m_BtnShop;
    public Button m_BtnRank;
    public Button m_BtnSound;

    void Start()
    {
        m_BtnStart.onClick.AddListener(OnDealStartGame);
        m_BtnStart.onClick.AddListener(OnDealShop);
        m_BtnStart.onClick.AddListener(OnDealRank);
        m_BtnStart.onClick.AddListener(OnDealSound);
    }

    void OnDealStartGame()
    {

    }

    void OnDealShop()
    {

    }

    void OnDealRank()
    {

    }

    void OnDealSound()
    {

    }

}
