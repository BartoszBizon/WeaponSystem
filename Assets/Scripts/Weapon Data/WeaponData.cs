using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponData : ScriptableObject
{
    [SerializeField] private string name;
    [SerializeField] private string damage;
    
    public string Name => name;
}
