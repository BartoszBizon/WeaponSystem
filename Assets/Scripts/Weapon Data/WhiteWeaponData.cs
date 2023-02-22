using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "White Weapon Data", menuName = "ScriptableObjects/Weapon Data/White Weapon Data")]
public class WhiteWeaponData : WeaponData
{
    [SerializeField] private int durability;
    [SerializeField] private TypeWhiteWeapon type;
}
