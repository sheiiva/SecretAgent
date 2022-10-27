using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.Localization.Settings;

public class LanguageSelection : MonoBehaviour
{
    public List<string> languages = new List<string>() { "English", "French", "Español" };

    private TMPro.TMP_Dropdown m_Dropdown;

    private void Start()
    {
        InitList();
    }

    private void InitList()
    {
        //Fetch the Dropdown GameObject the script is attached to
        m_Dropdown = GetComponent<TMPro.TMP_Dropdown>();
        //Clear the old options of the Dropdown menu
        m_Dropdown.ClearOptions();
        //Add the options created in the List above
        m_Dropdown.AddOptions(languages);
        m_Dropdown.RefreshShownValue();
    }

    public void ChangeLocale()
    {
        StartCoroutine(SetLocale(m_Dropdown.value));
    }

    IEnumerator SetLocale(int localeID)
    {
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localeID];
    }
}
