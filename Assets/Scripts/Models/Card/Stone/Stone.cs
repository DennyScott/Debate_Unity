using UnityEngine;
using System.Collections;

public class Stone : Card {

	private StoneColor Color;

	public Stone(Player owner, string name) : base(owner, name) {
		this.Color = StoneColor.NONE;
	}

	public Stone(Player owner, string name, StoneColor color): base(owner, name){
		this.Color = color;
	}

	public StoneColor color {
		get {return Color;}
		set {Color = value;}
	}
}
