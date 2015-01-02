using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player {
	private string Name;
	private int Health;
	private List<StatusEffect> StatusEffects;
	private Hand Hand;
	private Deck Deck;

	public Player(string name){
		this.Name = name;
		this.Health = GeneralConstants.STARTING_HEATH;
		Deck = new Deck();
		Hand = new Hand();
		this.StatusEffects = new List<StatusEffect>();
	}

	public string name {
		get { return Name; }
		set { Name = value; }
	}

	public int health {
		get { return Health; }
		set { Health = value; }
	}

	public List<StatusEffect> statusEffects {
		get { return StatusEffects; }
	}

	public Hand hand {
		get { return Hand; }
	}

	public Deck deck {
		get { return Deck; }
	}

	public int RemoveHealth(int damageAmount) {
		return health = health - damageAmount;
	}

	public bool DrawCard() {
		return Hand.AddCard(Deck.DrawCard());
	}

	public List<bool> DrawCard(int number){
		return Hand.AddCard(Deck.DrawCard(number));
	}

	public List<bool> DrawMaxCards() {
		int missingCards = GeneralConstants.FULL_HAND - Hand.Size();
		return DrawCard (missingCards);
	}



}
