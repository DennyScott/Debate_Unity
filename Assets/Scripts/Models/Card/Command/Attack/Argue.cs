using UnityEngine;
using System.Collections;

public class Argue : Command, IAttack {

	public Argue(Player owner, string text) : base(owner, text){
		cost = CommandConstants.ARGUE_COST;
		description = CommandConstants.ARGUE_DESCRIPTION;
	}

	public bool Action() {
		return false;
	}
}
