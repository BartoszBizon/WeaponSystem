using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Weapon Actions", menuName = "ScriptableObjects/Weapon Actions")]
public class WeaponActions : ScriptableObject
{
    public Action OnUseWeapon;
    public Action OnChangeWeapon;
    public Action<string> OnChangeWeaponName;
}
