using UnityEngine;

public class UIMenu : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject settingsPanel;
    private bool isSettingsPanelActive = false;
    
    private void Start()
    {
        closeSettingsPanel();
    }

    public void openSettingsPanel()
    {
        isSettingsPanelActive = true;
        mainMenuPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void closeSettingsPanel()
    {
        isSettingsPanelActive = false;
        mainMenuPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
