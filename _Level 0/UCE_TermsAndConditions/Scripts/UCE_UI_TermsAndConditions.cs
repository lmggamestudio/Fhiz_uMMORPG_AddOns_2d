using UnityEngine;

// =======================================================================================
// UCE UI TERMS AND CONDITIONS
// =======================================================================================
public partial class UCE_UI_TermsAndConditions : MonoBehaviour
{
    public GameObject panel;

    // -----------------------------------------------------------------------------------
    // Update
    // -----------------------------------------------------------------------------------
    private void Start()
    {
        if (PlayerPrefs.GetInt("UCETermsAndConditions", 0) == 1)
            Inactivate();
        else
            panel.SetActive(true);
    }

    // -----------------------------------------------------------------------------------
    // OnClickAccept
    // -----------------------------------------------------------------------------------
    public void OnClickAccept()
    {
        PlayerPrefs.SetInt("UCETermsAndConditions", 1);
        PlayerPrefs.Save();
        Inactivate();
    }

    // -----------------------------------------------------------------------------------
    // OnClickDecline
    // -----------------------------------------------------------------------------------
    public void OnClickDecline()
    {
        Application.Quit();
    }

    // -----------------------------------------------------------------------------------
    // Inactivate
    // -----------------------------------------------------------------------------------
    private void Inactivate()
    {
        panel.SetActive(false);
        Destroy(this.gameObject);
    }

    // -----------------------------------------------------------------------------------
}