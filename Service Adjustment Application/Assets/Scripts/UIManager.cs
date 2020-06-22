using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public static UIManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("The UI Manager is NULL");
            }
            return _instance;
        }
    }

    public Case activeCase;
    public ClientInfoPanel clientInfoPanel;
    public GameObject borderPanel;
    private void Awake()
    {
        _instance = this;
    }

    public void CreateNewCase()
    {
        activeCase = new Case();

        //generating a caseID
        int randomcaseID = Random.Range(0, 1000);
        activeCase.caseID = "" + randomcaseID;

        clientInfoPanel.gameObject.SetActive(true);
        borderPanel.gameObject.SetActive(true);
    }
}
