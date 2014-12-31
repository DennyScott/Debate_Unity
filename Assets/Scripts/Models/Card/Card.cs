using UnityEngine;
using System.Collections;

public class Card {
	private Player _owner;
	private string _name;

	public Card(Player owner, string text) {
		this.owner = owner;
		this._name = text;
	}

	public Player owner {
		get {return _owner;}
		set {_owner = value;}
	}

	public string name {
		get {return _name;}
		set {_name = value;}
	}

}
