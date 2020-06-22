using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientInfoPanel : MonoBehaviour, IPanel
{
    [SerializeField]
    private Text caseNumberText;
    public InputField firstName, lastName;
    public LocationPanel locationPanel;

    public void OnEnable()
    {
        caseNumberText.text = "CASE NUMBER " + UIManager.Instance.activeCase.caseID;   
    }

    public void ProcessInfo()
    {
        //check if firstName && lastName are not empty
        if(string.IsNullOrEmpty(firstName.text) || string.IsNullOrEmpty(lastName.text))
        {
            Debug.Log("Either first or last name is empty.");
        }
        else
        {
            UIManager.Instance.activeCase.name = firstName.text + " " + lastName.text;
            locationPanel.gameObject.SetActive(true);
        }
    }
}
