using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player {
	private string _name;
	private int _health;
	private List<StatusEffect> _statusEffects;
	private Hand _hand;
	private Deck _deck;

	public Player(string name){
		_name = name;
		_health = GeneralConstants.STARTING_HEATH;
		_deck = new Deck();
		_hand = new Hand();
		_statusEffects = new List<StatusEffect>();
	}

	public string name {
		get { return _name; }
		set { _name = value; }
	}

	public int health {
		get { return _health; }
		set { _health = value; }
	}

	public List<StatusEffect> statusEffects {
		get { return _statusEffects; }
	}

	public Hand hand {
		get { return _hand; }
	}

	public Deck deck {
		get { return _deck; }
	}

	public int RemoveHealth(int damageAmount) {
		return health = health - damageAmount;
	}

	public bool DrawCard() {
		return _hand.AddCard(_deck.DrawCard());
	}

	public List<bool> DrawCard(int number){
		return _hand.AddCard(_deck.DrawCard(number));
	}

	public List<bool> DrawMaxCards() {
		int missingCards = GeneralConstants.FULL_HAND - _hand.Size();
		return DrawCard (missingCards);
	}



}
