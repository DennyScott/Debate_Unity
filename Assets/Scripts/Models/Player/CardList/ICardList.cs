using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface ICardList {

	//Methods
	bool AddCard(Card card);
	bool AddCard(Card card, int position);
	List<bool> AddCard(List<Card> cards);
	bool IsFull();
	bool IsEmpty();
	int Size();
	Card RemoveCard(int position);
	int FindCardByName(string name);
	int[] FindCardsByName(string name);

	//Properties
	int full {
		get;
		set;
	}

}
