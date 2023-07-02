using UnityEngine;
using BackEnd;

public class BackendManager : MonoBehaviour
{
    void Awake()
    {
        Setup();
    }
    
    void Setup()
    {
        var beObj = Backend.Initialize(true);

        if (beObj.IsSuccess())
        {
            print($"success + {beObj}");
        }
        else
        {
            Debug.LogError("failed");
        }
    }
}
