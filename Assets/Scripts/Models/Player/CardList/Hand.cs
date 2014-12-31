using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Hand : CardList {

	private List<Card> _hand;

	public Hand() : base(){
		full = GeneralConstants.FULL_HAND;
	}

}
