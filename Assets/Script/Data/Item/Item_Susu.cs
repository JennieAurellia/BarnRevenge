using UnityEngine;

public class Item_Susu : Item
{
    public Item_Susu()
    {
        _name = "Susu";
        _upgradeCostBase = 1.5f;
        _upgradeCostMultiplier = 1.15f;
        _sellBase = 15f;
        _sellMultiplier = 1.24f;
        _sellValue = _sellBase;
        _upgradeCost = _upgradeCostBase;
        _level = 1;
    }

    public override string name
    {
        get { return _name; }
    }

    public override float sellValue
    {
        get { return Mathf.Round(_sellValue); }
        set { _sellValue = value; }
    }

    public override float upgradeCost
    {
        get { return Mathf.Round(_upgradeCost); }
        set { _upgradeCost = value; }
    }

    public override int level
    {
        get { return _level; }
        set { _level = value; }
    }

    public override float upgradeCostBase
    {
        get { return 3.5f; }
    }

    public override float upgradeCostMultiplier
    {
        get { return 1.2f; }
    }

    public override float sellBase
    {
        get { return 35f; }
    }

    public override float sellMultiplier
    {
        get { return 1.28f; }
    }

    public override void UpgradeItem()
    {
        upgradeCost = upgradeCostBase * Mathf.Pow(level, upgradeCostMultiplier);
        sellValue = sellBase * Mathf.Pow(sellMultiplier, level - 1);
        level++;
    }
}
