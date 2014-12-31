using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardList : ICardList {

	protected List<Card> _cardList;
	protected int _full;

	public CardList() {
		_cardList = new List<Card>();
		_full = GeneralConstants.DEFAULT_CARDLIST_FULL;
	}

	public int full {
		get { return full; }
		set { full = value; }
	}

	public bool AddCard(Card card){
		if(!IsFull() && card != null){
			_cardList.Add(card);
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
			_cardList.Insert(position, card);
			return true;
		}
		return false;
	}

	public bool IsFull() {
		return _cardList.Count >= _full;
	}

	public bool IsEmpty() {
		return _cardList.Count == 0;
	}

	public int Size() {
		return _cardList.Count;
	}

	public Card GetCard(int position){
		if(_cardList.Count-1 >= position) {
			return _cardList[position];
		}
		return null;
	}

	public Card RemoveCard(int position){
		if(_cardList.Count-1 >= position) {
			Card card = _cardList[position];
			_cardList.RemoveAt(position);
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
