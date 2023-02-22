using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private WeaponActions weaponActions;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            weaponActions.OnUseWeapon();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            weaponActions.OnChangeWeapon();
        }
    }
}
