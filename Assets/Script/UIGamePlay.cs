using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIGamePlay : MonoBehaviour
{
    public TextMeshProUGUI coinTxt;
    public TextMeshProUGUI levelTxt;
    public TMP_Dropdown itemDropdown;
    public TextMeshProUGUI sellValueTxt;
    public EntityPlayer player;

    public TMP_Dropdown uiDropdown;
    public GameObject dayUi;
    // public GameObject nightUi;
    public GameObject saveLoadUi;

    private Item item;

    void Start()
    {
        itemDropdown.value = 0;
        item = GameManager.Instance.itemSusu;

        SwitchUi();
    }

    void Update()
    {
        updateTxt();
    }

    void updateTxt()
    {
        coinTxt.text = player.Coin.ToString();
        levelTxt.text = item.level.ToString();
        sellValueTxt.text = item.sellValue.ToString();
    }

    public void Upgrade()
    {
        player.upgradeItem(item);
    }

    public void Sell()
    {
        player.sellItem(item);
    }

    public void ChangeItem()
    {
        int index = itemDropdown.value;
        switch (index)
        {
            case 0:
                item = GameManager.Instance.itemSusu;
                break;
            case 1:
                item = GameManager.Instance.itemBuluDomba;
                break;
            case 2:
                item = GameManager.Instance.itemBuluDomba;
                break;
            case 3:
                item = GameManager.Instance.itemLemakBabi;
                break;
        }
        Debug.Log(index + " " + item.name);
    }

    #region Debugging
    public void SwitchUi()
    {
        switch (uiDropdown.value)
        {
            case 0: // Day Upgrade
                dayUi.gameObject.SetActive(true);
                saveLoadUi.gameObject.SetActive(false);
                break;
            case 1: // Night Upgrade
                break;
            case 2: // Save Ui
                dayUi.gameObject.SetActive(false);
                saveLoadUi.gameObject.SetActive(true);
                break;

        }
    }


    #endregion
}
