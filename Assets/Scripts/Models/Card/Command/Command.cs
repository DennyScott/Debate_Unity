using UnityEngine;
using System.Collections;

public class Command : Card {

	private int _cost;
	private string _description;

	public Command(Player owner, string name): base(owner, name){
		this._cost = CommandConstants.DEFAULT_COMMAND_COST;
		this._description = CommandConstants.DEFAULT_COMMAND_DESCRIPTION;
	}

	public int cost {
		get { return _cost; }
		set { _cost = value; }
	}

	public string description {
		get { return _description; }
		set { _description = value; }
	}
}
