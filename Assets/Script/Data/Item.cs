using UnityEngine;

[System.Serializable]
public class Item : Upgrades
{
    private float _sellBase;
    private float _sellMultiplier;
    private int _animalCapacity;

    public float sellBase { get { return _sellBase; } protected set { _sellBase = value; }}
    public float sellMultiplier { get { return _sellMultiplier; } protected set { _sellMultiplier = value; }}
    public float sellValue { get {return Mathf.Round(sellBase * Mathf.Pow(sellMultiplier, level - 1)); }}
    public override float upgradeCost { get { return Mathf.Round(upgradeCostBase * Mathf.Pow(level, upgradeCostMultiplier)); }}
    public int animalCapacity { get { return _animalCapacity; } protected set { _animalCapacity = value; }}

    // inisiate item
    public Item(string Name, int Level, float SellBase, float SellMultiplier, float UpgradeCostBase, float UpgradeCostMultiplier, int AnimalCapacity, CurrType currType) : base (Name, Level, UpgradeCostBase, UpgradeCostMultiplier, currType)
    {
        sellBase = SellBase;
        sellMultiplier = SellMultiplier;
        animalCapacity = AnimalCapacity;
    }

    public void AddAnimalCapacity()
    {
        animalCapacity++;
    }
}
