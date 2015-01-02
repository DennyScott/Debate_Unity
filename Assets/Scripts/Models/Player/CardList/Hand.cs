using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Hand : CardList {

	private List<Card> hand;

	public Hand() : base(){
		Full = GeneralConstants.FULL_HAND;
	}

}
