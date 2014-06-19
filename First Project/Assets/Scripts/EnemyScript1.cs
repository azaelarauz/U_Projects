using UnityEngine;
using System.Collections;

public class EnemyScript1 : MonoBehaviour {

	// Use this for initialization
	private WeaponScript[] weapons;

	void Awake()
	{
		// Retrieve the weapon only once
		weapons = GetComponentsInChildren<WeaponScript>();
	}

	void Update()
	{
		// Auto-fire
		foreach(WeaponScript weapon in weapons)
		if (weapons != null && weapon.CanAttack)
		{
			weapon.Attack(true);
		}
	}
}
