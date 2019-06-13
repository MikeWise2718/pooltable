using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UxSetting<T>
{
    [SerializeField]
    public T val;
    [SerializeField]
    public bool bval;
}

[System.Serializable]
public class UxSetting1:UxSetting<bool>
{

}

[System.Serializable]
public class UxSetting0
{
    [SerializeField]
    public bool val;
}
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public UxSetting0 setting0;
    public UxSetting1 setting1;
    public UxSetting<bool> setting;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
