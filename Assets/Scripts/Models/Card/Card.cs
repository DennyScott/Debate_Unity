using UnityEngine;
using System.Collections;

public class Card {
	private Player Owner;
	private string Name;

	public Card(Player owner, string text) {
		this.Owner = owner;
		this.Name = text;
	}

	public Player owner {
		get {return Owner;}
		set {Owner = value;}
	}

	public string name {
		get {return Name;}
		set {Name = value;}
	}

}
