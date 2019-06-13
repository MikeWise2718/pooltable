using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UxSetting<T>
{
    [SerializeField]
    public T val;
}
    public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public UxSetting<bool> setting;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
