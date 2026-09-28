using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIGamePlay : MonoBehaviour
{
    public GameObject buyButton;
    public GameObject sellButton;
    public TextMeshProUGUI coin;
    public EntityPlayer player;

    public TMP_Dropdown itemDropdown;
    private Item item;
    // private Item_Telur itemTelur = new Item_Telur();
    // private Item_Susu itemSusu = new Item_Susu();
    // private Item_BuluDomba itemBuluDomba = new Item_BuluDomba();
    private Item_LemakBabi itemLemakBabi = new Item_LemakBabi();

    void Start()
    {
        // itemDropdown.value = 0;
        // item = itemSusu;

        item = itemLemakBabi;
    }

    void Update()
    {
        coin.text = player.Coin.ToString();
    }

    public void Upgrade()
    {
        player.upgradeItem(item);
    }

    public void Sell()
    {
        player.sellItem(item);
    }

    public void ChangeItem(int index)
    {
        // switch (index)
        // {
        //     case 0:
        //         item = itemSusu;
        //         break;
        //     case 1:
        //         item = itemLemakBabi;
        //         break;
        //     case 2:
        //         item = itemTelur;
        //         break;
        //     case 3:
        //         item = itemBuluDomba;
        //         break;
        // }
    }
}
