using UnityEngine;

public class Item_LemakBabi : Item
{
    public Item_LemakBabi()
    {
        _name = "Lemak Babi";
        _upgradeCostBase = 3.5f;
        _upgradeCostMultiplier = 1.2f;
        _sellBase = 35f;
        _sellMultiplier = 1.28f;
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
