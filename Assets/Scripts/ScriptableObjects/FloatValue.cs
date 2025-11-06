using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[System.Serializable]
public class FloatValue : ScriptableObject, ISerializationCallbackReceiver
{
    public float initialValue;

    // [HideInInspector]
    public float RuntimeValue;

    // Initialize RuntimeValue when the game starts or scene changes
    public void OnEnable()
    {
        RuntimeValue = initialValue;
    }

    public void OnAfterDeserialize()
    {
        RuntimeValue = initialValue;
    }

    public void OnBeforeSerialize() { }
}
