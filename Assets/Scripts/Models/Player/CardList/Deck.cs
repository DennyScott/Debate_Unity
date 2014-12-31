using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : CardList {

	public Deck() : base() {
		full = GeneralConstants.DECK_SIZE;
	}

	public bool AddCardInRandomPosition(Card card){
		return AddCard (card, Random.Range(0, Size() - 1));
	}

	public Card DrawCard() {
		return RemoveCard(0);
	}

	public List<Card> DrawCard(int number) {
		List<Card> drawnCards = new List<Card>();
		for(int i = 0; i < number; i++){
			drawnCards.Add(DrawCard());
		}
		return drawnCards;
	}

	public Card DrawRandomCard() {
		return RemoveCard (Random.Range (0, Size () - 1));
	}

	public void ShuffleDeck() {
		for (int i = 0; i < _cardList.Count; i++) {
			Card temp = _cardList[i];
			int randomIndex = Random.Range(i, _cardList.Count);
			_cardList[i] = _cardList[randomIndex];
			_cardList[randomIndex] = temp;
		}
	}
}
