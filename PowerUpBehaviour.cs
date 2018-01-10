using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PowerUpBehaviour : MonoBehaviour {

	public PowerUpBase PowerUpSO;

	void OnTriggerEnter(Collider other)
	{
		print(PowerUpSO.PowerLevel);
	}

	[ContextMenu("Add Sprite")]
	void Start()
	{
		GetComponent<SpriteRenderer>().sprite = PowerUpSO.UpdateSprite();
	}
}
