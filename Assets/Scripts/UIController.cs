using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private WeaponActions weaponActions;
    [SerializeField] private TextMeshProUGUI weaponName;

    private void Start()
    {
        weaponActions.OnChangeWeaponName += SetTextWeaponName;
    }
    
    private void OnDestroy()
    {
        weaponActions.OnChangeWeaponName -= SetTextWeaponName;
    }

    private void SetTextWeaponName(string newWeaponName)
    {
        weaponName.text = newWeaponName;
    }
}
