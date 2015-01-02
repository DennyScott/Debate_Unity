using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardList : ICardList {

	protected List<Card> cardList;
	protected int Full;

	public CardList() {
		this.cardList = new List<Card>();
		this.Full = GeneralConstants.DEFAULT_CARDLIST_FULL;
	}

	public int full {
		get { return Full; }
		set { Full = value; }
	}

	public bool AddCard(Card card){
		if(!IsFull() && card != null){
			cardList.Add(card);
			return true;
		}
		return false;
	}

	public List<bool> AddCard(List<Card> cards) {
		List<bool> success = new List<bool>();
		for(int i = 0; i < cards.Count; i++){
			success.Add(AddCard(cards[i]));
		}
		return success;
	}

	public bool AddCard(Card card, int position){
		if(!IsFull() && card != null && position < Size() && position > -1){
			cardList.Insert(position, card);
			return true;
		}
		return false;
	}

	public bool IsFull() {
		return cardList.Count >= Full;
	}

	public bool IsEmpty() {
		return cardList.Count == 0;
	}

	public int Size() {
		return cardList.Count;
	}

	public Card GetCard(int position){
		if(cardList.Count-1 >= position) {
			return cardList[position];
		}
		return null;
	}

	public Card RemoveCard(int position){
		if(cardList.Count-1 >= position) {
			Card card = cardList[position];
			cardList.RemoveAt(position);
			return card;
		}
		return null;
	}

	public int FindCardByName(string name){
		return 0;
	}

	public int[] FindCardsByName(string name){
		return new int[0];
	}
}
