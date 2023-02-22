using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsController : MonoBehaviour
{
    [SerializeField] private WeaponActions weaponActions;
    [SerializeField] private List<Weapon> weapons;

    private int _weaponIndex;

    private void Start()
    {
        weaponActions.OnUseWeapon += UseWeapon;
        weaponActions.OnChangeWeapon += ChangeWeapon;

        SetupCurrentWeapon();
    }

    private void OnDestroy()
    {
        weaponActions.OnUseWeapon -= UseWeapon;
        weaponActions.OnChangeWeapon -= ChangeWeapon;
    }

    private void UseWeapon()
    {
        weapons[_weaponIndex].UseWeapon();
    }

    private void ChangeWeapon()
    {
        weapons[_weaponIndex].gameObject.SetActive(false);
        _weaponIndex = _weaponIndex == weapons.Count - 1 ? 0 : _weaponIndex + 1;
        SetupCurrentWeapon();
    }

    private void SetupCurrentWeapon()
    {
        weapons[_weaponIndex].gameObject.SetActive(true);
        var weaponName = weapons[_weaponIndex].weaponData.Name;
        weaponActions.OnChangeWeaponName(weaponName);
    }

}
