using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public abstract class Weapon : MonoBehaviour, IUseWeapon
{
    [SerializeField] public WeaponData weaponData;
    public abstract void UseWeapon();
}
