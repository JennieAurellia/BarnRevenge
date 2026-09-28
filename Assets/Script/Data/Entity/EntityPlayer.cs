using UnityEngine;

public class EntityPlayer : MonoBehaviour
{
    private Entity entity = new Entity();
    private float _maxHP;
    private float _playerHP;
    private float _moveSpeed;
    private float _ATK;
    private float _ATKSpeed;
    private float coin = 1000f;
    
    private void Awake()
    {
        _maxHP = entity.HP;
        _playerHP = _maxHP;
        _moveSpeed = entity.moveSpeed;
        _ATK = entity.ATK;
        _ATKSpeed = entity.ATKSpeed;
    }

    public float PlayerHP
    { 
        get { return _playerHP; } 
        set 
        { 
            if (value < 0) 
            { 
                _playerHP = 0; 
            } 
            else if (value > _maxHP) 
            { 
                _playerHP = _maxHP;
            } 
            else 
            { 
                _playerHP = value; 
            }
        } 
    }

    public float MoveSpeed
    {
        get { return _moveSpeed; }
        set { _moveSpeed = value; }
    }

    public float ATK
    {
        get { return _ATK; }
        set { _ATK = value; }
    }

    public float ATKSpeed
    {
        get { return _ATKSpeed; }
        set { _ATKSpeed = value; }
    }

    public float Coin
    {
        get { return coin; }
        set { coin = value; }
    }

    public float sellItem(Item item)
    {
        coin += item.sellValue;
        Debug.Log("Selling " + item.name + " at value: " + item.sellValue + " at level: " + item.level);
        return coin;
    }

    public float upgradeItem(Item item)
    {
        if (coin >= item.upgradeCost)
        {
            coin -= item.upgradeCost;
            Debug.Log("Buying Upgrade for " + item.name + " at cost: " + item.upgradeCost + " at level: " + item.level);
            item.UpgradeItem();
            return coin;
        }
        else
        {
            Debug.Log("Not enough coin to upgrade the item.");
            return coin;
        }
    }
}
