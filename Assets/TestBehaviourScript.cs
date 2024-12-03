using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            Debug.Log("NewBehaviourScript.Start");
        }
        catch (System.Exception)
        {
            // ERP022 should be shown
        }
    }
}
