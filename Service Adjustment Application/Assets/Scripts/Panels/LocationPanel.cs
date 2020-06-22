using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationPanel : MonoBehaviour, IPanel
{
    public RawImage map;
    public InputField mapNotes;

    public string apiKey;
    private float xCord;
    private float yCord;

    public IEnumerator Start()
    {
        //Fetch GEO data
        if(Input.location.isEnabledByUser == true)
        {
            //start service.
            Input.location.Start();
            int maxWait = 20;
            while(Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
            {
                yield return new WaitForSeconds(1.0f);
                maxWait--;
            }

            if(maxWait < 1)
            {
                Debug.Log("Timed Out");
                yield break;
            }

            if(Input.location.status == LocationServiceStatus.Failed)
            {
                Debug.Log("Unable to determine device location...");
            }
            else
            {
                xCord = Input.location.lastData.latitude;
                yCord = Input.location.lastData.longitude;
            }

            Input.location.Stop();
        }
        else
        {
            Debug.Log("Location Services are not Enabled");
        }
        
    }

    public void OnEnable()
    {
        Debug.Log("LocationPanel:: OnEnabled()");
              //Download static map
              //apply the map to the raw img.
            
    }

    public void ProcessInfo()
    {
       
    }
}
