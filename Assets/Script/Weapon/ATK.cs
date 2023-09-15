using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon_Data", menuName = "Data/ATK", order = int.MaxValue)]
public class ATK : ScriptableObject
{
    public int Damage;
    public Sprite WeaponImage;
}
