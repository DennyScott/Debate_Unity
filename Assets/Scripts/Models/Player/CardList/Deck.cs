using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : CardList {

	public Deck() : base() {
		Full = GeneralConstants.DECK_SIZE;
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
		for (int i = 0; i < cardList.Count; i++) {
			Card temp = cardList[i];
			int randomIndex = Random.Range(i, cardList.Count);
			cardList[i] = cardList[randomIndex];
			cardList[randomIndex] = temp;
		}
	}
}
