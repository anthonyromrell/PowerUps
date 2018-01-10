using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUpBase : ScriptableObject {

	public Sprite PowerUpSprite;
	public float PowerLevel = 1;

	public Sprite UpdateSprite () {
		return PowerUpSprite;
	}
}
