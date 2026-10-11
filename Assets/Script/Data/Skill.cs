using UnityEngine;

[System.Serializable]
public class Skill : Upgrades
{
    public override float upgradeCost { get { return Mathf.Round(upgradeCostBase * Mathf.Pow(upgradeCostMultiplier, (level - 1))); }}
    public Skill(string Name, int Level, float UpgradeCostBase, float UpgradeCostMultiplier, CurrType currType) : base (Name, Level, UpgradeCostBase, UpgradeCostMultiplier, currType)
    {
        
    }
}
