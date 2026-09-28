using UnityEngine;

public class Item
{
    public string _name = "Item";
    public float _sellValue = 0f;
    public float _upgradeCost = 0f;
    public int _level = 1;
    public float _upgradeCostBase = 0f;
    public float _upgradeCostMultiplier = 0f;
    public float _sellBase = 0f;
    public float _sellMultiplier = 0f;

    public virtual string name { get; set; }
    public virtual float sellValue { get; set; }
    public virtual float upgradeCost { get; set; }
    public virtual int level { get; set; }
    public virtual float upgradeCostBase {get; set;}
    public virtual float upgradeCostMultiplier {get; set;}
    public virtual float sellBase {get; set;}
    public virtual float sellMultiplier {get; set;}
    public virtual void UpgradeItem()
    {
        
    }
}
