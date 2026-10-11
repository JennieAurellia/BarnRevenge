using UnityEngine;

public enum CurrType
{
    Coin,
    Soul
}

[System.Serializable]
public class Upgrades
{
    [SerializeField] private string _name;
    [SerializeField] private int _level;
    private float _upgradeCostBase;
    private float _upgradeCostMultiplier;
    private CurrType _currType;

    public string name { get { return _name; } protected set { _name = value; }}
    public int level { get { return _level; } protected set { _level = value; }}
    public float upgradeCostBase { get { return _upgradeCostBase; } protected set { _upgradeCostBase = value; }}
    public float upgradeCostMultiplier { get { return _upgradeCostMultiplier; } protected set { _upgradeCostMultiplier = value; }}
    public virtual float upgradeCost { get; }
    public CurrType currType { get { return _currType; } protected set { _currType = value; }}

    protected Upgrades(string Name, int Level, float UpgradeCostBase, float UpgradeCostMultiplier, CurrType type)
    {
        name = Name;
        level = Level;
        upgradeCostBase = UpgradeCostBase;
        upgradeCostMultiplier = UpgradeCostMultiplier;
        currType = type;
    }

    public void Upgrade()
    {
        level++;
    }

}
