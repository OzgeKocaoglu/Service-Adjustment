using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Amazon;

public class ASW_Manager : MonoBehaviour
{
    private void Awake()
    {
        UnityInitializer.AttachToGameObject(this.gameObject);
    }
}
