using UnityEngine;
using System.Collections;

public class Stone : Card {

	private StoneColor _color;

	public Stone(Player owner, string name, StoneColor color): base(owner, name){
		this._color = color;
	}

	public StoneColor color {
		get {return _color;}
		set {_color = value;}
	}
}
