using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
[Category("Deck Tests")]
public class DeckTest {

	Player testPlayer;
	Card testCardOne, testCardTwo;
	Deck testDeck;

	[SetUp]
	public void Init() {
		testPlayer = new Player("Andy");
		testCardOne = new Card(testPlayer, "testOne");
		testCardTwo = new Card(testPlayer, "testTwo");
		testDeck = new Deck();
	}

	[Test]
	public void AddACardToTheDeck() {
		bool added = testDeck.AddCard(testCardOne);
		Assert.IsTrue(added);
		Assert.AreEqual(testCardOne, testDeck.GetCard(0));
	}

	[Test]
	public void DrawingCardTakesTopCard() {
		testDeck.AddCard(testCardOne);
		testDeck.AddCard(testCardTwo);
		Assert.AreEqual(testCardOne, testDeck.DrawCard());
	}

	[Test]
	public void AddingNullToDeckReturnsFalse() {
		bool added = testDeck.AddCard((Card) null);
		Assert.IsFalse(added);
	}

	[Test]
	public void DrawingAnEmptyCardWillReturnNull() {
		Assert.AreEqual(null, testDeck.DrawCard());
	}

	[Test]
	public void SizeReturnsCorrectSizeOfDeck() {
		Assert.AreEqual(0, testDeck.Size());
		testDeck.AddCard(testCardOne);
		Assert.AreEqual(1, testDeck.Size());
	}

	[Test]
	public void DrawingRandomCardPullsFromRandomPlaceInDeck() {
		testDeck.AddCard(testCardOne);
		for(int i = 0; i < 1000; i++){
			testDeck.AddCard(testCardTwo);
		}
		Assert.AreEqual(testCardTwo, testDeck.DrawRandomCard());
		Assert.AreNotEqual(testCardTwo, testDeck.DrawCard());
	}

	[Test]
	public void DrawingARandomCardWithNoDeckReturnsNull() {
		Assert.AreEqual(null, testDeck.DrawRandomCard());
	}

	[Test]
	public void ShuffleDeckWillMoveCardOffFirstElement() {
		testDeck.AddCard(testCardOne);
		for(int i = 0; i < 1000; i++){
			testDeck.AddCard(testCardTwo);
		}

		testDeck.ShuffleDeck();
		Assert.AreNotEqual(testCardOne, testDeck.GetCard(0));
	}

	[Test]
	public void getCardAtPositionWillReturnThatCardFromDeck() {
		testDeck.AddCard(testCardOne);
		testDeck.AddCard(testCardTwo);
		Assert.AreEqual(testCardTwo, testDeck.GetCard(1));
	}

	[Test]
	public void AddCardInRandomPosition() {
		testDeck.full = 1010;
		for(int i = 0; i < 1000; i++){
			testDeck.AddCard(testCardTwo);
		}
		Assert.AreEqual(1000, testDeck.Size());
		bool added = testDeck.AddCardInRandomPosition (testCardOne);
		Assert.AreEqual(1001, testDeck.Size ());
		Assert.IsTrue(added);
		Assert.AreEqual(testCardTwo, testDeck.GetCard(testDeck.Size () - 1));
	}
}
