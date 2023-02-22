using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Fire Weapon Data", menuName = "ScriptableObjects/Weapon Data/Fire Weapon Data")]
public class FireWeaponData : WeaponData
{
    [SerializeField] private int bulletsAmount;
    [SerializeField] private TypeFireWeapon type;
}
