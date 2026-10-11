using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using NUnit.Framework.Internal;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.Overlays;

public class GameManager : MonoBehaviour
{
    #region ===== Game Manager =====
    public static GameManager Instance;
    private string saveFilePath;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // Create Save Folder
        string saveFolder = Path.Combine(Application.persistentDataPath, "Save");
        Directory.CreateDirectory(saveFolder);

        saveFilePath = Path.Combine(saveFolder, "saveDummy.json");

        InisiateSkill();
        InisiateItems();
    }
    #endregion

    #region ===== Items =====
    public Item itemSusu;
    public Item itemTelur;
    public Item itemBuluDomba;
    public Item itemLemakBabi;
    public void InisiateItems()
    {
        // Item(string Name, int Level, float SellBase, float SellMultiplier, float UpgradeCostBase, float UpgradeCostMultiplier, int AnimalCapacity)
        itemSusu = new Item("Susu", 1, 15f, 1.24f, 1.5f, 1.15f, 0, CurrType.Coin);
        itemTelur = new Item("Telur", 1, 12f, 1.22f, 1.2f, 1.15f, 0, CurrType.Coin);
        itemBuluDomba = new Item ("Bulu Domba", 1, 25f, 1.26f, 2.5f, 1.18f, 0, CurrType.Coin);
        itemLemakBabi = new Item("Lemak Babi", 1, 35f, 1.28f, 3.5f, 1.2f, 0, CurrType.Coin);
    }

    private List<Item> ItemList()
    {
        List<Item> items = new List<Item>()
        {
            itemSusu,
            itemTelur,
            itemBuluDomba,
            itemLemakBabi
        };
        return items;
    }

    #endregion

    #region ===== Skill =====
    public Skill skillAtk;
    public Skill skillAtkSpeed;
    public Skill skillHp;
    public Skill skillMoveSpeed;
    public Skill skillCapacityChiken;
    public Skill skillCapacityPig;
    public Skill skillCapacitySheep;
    public Skill skillCapacityCow;
    public Skill skillCapacityBackPack;
    private void InisiateSkill()
    {
        // Skill(string Name, int Level, float UpgradeCostBase, float UpgradeCostMultiplier)
        skillAtk = new Skill("Atk", 1, 51f, 1.42f, CurrType.Coin);
        skillAtkSpeed = new Skill("Atk Speed", 1, 56f, 1.42f, CurrType.Coin);
        skillHp = new Skill("Hp", 1, 43f, 1.42f, CurrType.Coin);
        skillMoveSpeed = new Skill("MoveSpeed", 1, 20f, 1.28f, CurrType.Coin);
        skillCapacityChiken = new Skill("CapacityChiken", 1, 24f, 1.24f, CurrType.Coin);
        skillCapacityPig = new Skill("CapacityPig", 1, 36f, 1.28f, CurrType.Coin);
        skillCapacitySheep = new Skill("CapacitySheep", 1, 28f, 1.25f, CurrType.Coin);
        skillCapacityCow = new Skill("CapacityCow", 1, 32f, 1.26f, CurrType.Coin);
        skillCapacityBackPack = new Skill("CapacityBackPack", 1, 40f, 1.27f, CurrType.Coin);
    }

    private List<Skill> SkillList()
    {
        List<Skill> skills = new List<Skill>()
        {
            skillAtk,
            skillAtkSpeed,
            skillHp,
            skillMoveSpeed,
            skillCapacityChiken,
            skillCapacityPig,
            skillCapacitySheep,
            skillCapacityCow,
            skillCapacityBackPack
        };

        return skills;
    }


    #endregion

    #region ===== Save =====
    public void SaveGame()
    {
        Save data = new Save();

        List<Item> items = new List<Item>()
        {
            itemSusu,
            itemTelur,
            itemBuluDomba,
            itemLemakBabi
        };

        data.skills = SkillList();
        data.items = items;

        Debug.Log(data.items[0].name);

        // Write Save File
        string json = JsonUtility.ToJson(data, true);
        Debug.Log(json);
        File.WriteAllText(saveFilePath, json);

        Debug.Log("Game Manager: Game Saved at " + saveFilePath);
    }

    public void LoadGame()
    {
        if (!File.Exists(saveFilePath))
        {
            Debug.Log("Game Manager: Save File Didn't Exist");
            return;
        }

        string json = File.ReadAllText(saveFilePath);
        SaveData data = JsonUtility.FromJson<SaveData>(json);

        // Debug.Log(data.skills.count());

    }

    #endregion

    #region ===== Utils =====
    public void ChangeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    #endregion
}
