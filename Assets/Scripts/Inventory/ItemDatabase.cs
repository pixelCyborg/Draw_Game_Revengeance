﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {
	public List<Item> items = new List<Item>();

	void Start() {
		//Lever Action Rifle
		items.Add(new Item("Lever Rifle", 1, "Sample Text", Item.ItemType.Weapon));
		items[0].BuildGun(Item.Base.LeverRifle, 50, 1200, 1.5f, 3, 5);
		//Revolver
		items.Add(new Item("Revolver", 2, "Your trusty revolver", Item.ItemType.Weapon));
		items[1].BuildGun(Item.Base.Revolver, 25, 600, 0.5f, 2, 6);
	}
}