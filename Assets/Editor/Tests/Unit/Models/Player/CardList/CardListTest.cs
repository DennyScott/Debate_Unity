using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
[Category("Card List Tests")]
public class CardListTest  {

	CardList testList;
	Player testPlayer;
	Card testCardOne, testCardTwo;
	readonly string playerName = "Andy";

	[SetUp]
	public void Init() {
		testList = new CardList();
		testPlayer = new Player(playerName);
		testCardOne = new Card(testPlayer, "testcardone");
		testCardTwo = new Card(testPlayer, "testcardtwo");
	}

	[Test]
	public void AddingACardPlacedCardInCardList() {
		bool added = testList.AddCard(testCardOne);
		Assert.IsTrue(added);
		Assert.AreEqual(testCardOne, testList.GetCard(0));
	}

	[Test]
	public void AddingACardWithPositionAddsTheCardToThatPosition() {
		testList.AddCard(testCardOne);
		testList.AddCard(testCardTwo);
		bool added = testList.AddCard(testCardOne, 1);
		Assert.IsTrue(added);
		Assert.AreSame(testCardOne, testList.GetCard(1));
	}

	[Test]
	public void AddingACardInPositionWhileListIsFullReturnsFalse() {
		testList.full = 0;
		bool added = testList.AddCard(testCardOne, 0);
		Assert.IsFalse(added);
	}

	[Test]
	public void AddingACardInPositionWhileCardIsNullReturnsFalse() {
		bool added = testList.AddCard(null, 0);
		Assert.IsFalse(added);
	}

	[Test]
	public void AddingACardWithAPositionLowerThenZeroWillReturnFalse() {
		bool added = testList.AddCard(testCardOne, -1);
	}

	[Test]
	public void AddingACardWithAPositionHigherThenSizeOfListWillReturnFalse() {
		bool added = testList.AddCard(testCardOne, 1);
		Assert.IsFalse(added);
	}
	
	[Test]
	public void AddingListOfCardsWillAddCardsToCardList() {
		List<Card> cards = new List<Card>();
		for(int i = 0; i < 3; i++){
			cards.Add(testCardOne);
		}

		List<bool> success = testList.AddCard(cards);
		Assert.AreEqual(3, success.Count);
		for(int i = 0; i < 3; i++){
			Assert.AreEqual(testCardOne, testList.GetCard(i));
			Assert.IsTrue(success[i]);
		}
		Assert.AreEqual(3, testList.Size());
	}

	[Test]
	public void AddingListOfCardsWithOneNullWillNotAddNullAndReturnFalse() {
		List<Card> cards = new List<Card>();
		for(int i = 0; i < 3; i++){
			cards.Add (testCardOne);
		}
		cards.Add (null);
		List<bool> success = testList.AddCard(cards);
		Assert.AreEqual(4, success.Count);
		Assert.AreEqual(3, testList.Size());
		Assert.IsFalse(success[3]);
	}

	[Test]
	public void GetCardReturnsTheCardAtDesiredPosition(){
		testList.AddCard(testCardOne);
		testList.AddCard(testCardTwo);

		Assert.AreEqual(testCardOne, testList.GetCard(0));
		Assert.AreEqual(testCardTwo, testList.GetCard(1));
	}

	[Test]
	public void SettingFullWillChangeTheFullAmount() {
		Assert.AreEqual(GeneralConstants.DEFAULT_CARDLIST_FULL, testList.full);
		testList.full = 10;
		Assert.AreEqual(10, testList.full);
	}

	[Test]
	public void AddingACardWhenListIsFullReturnsFalse() {
		testList.full = 0;
		bool added = testList.AddCard(testCardTwo);
		Assert.IsFalse(added);
	}

	[Test]
	public void AddingANullIntoAListWillReturnFalse() {
		bool added = testList.AddCard((Card) null);
		Assert.IsFalse(added);
	}

	[Test]
	public void GettingACardThatDoesntExistReturnsNull() {
		testList.AddCard(testCardOne);
		Assert.AreEqual(null, testList.GetCard(2));
	}

	[Test]
	public void IsEmptyWillBeTrueIfListIsEmpty() {
		Assert.IsTrue(testList.IsEmpty());
	}

	[Test]
	public void IsEmptyWillBeFalseIfListIsEmpty() {
		testList.AddCard(testCardOne);
		Assert.IsFalse (testList.IsEmpty());
	}

	[Test]
	public void IsFullWillBeFalseIfTheListDoesNotReachFull() {
		testList.full= 100;
		Assert.IsFalse(testList.IsFull());
	}

	[Test]
	public void IsFullWillBeTrueIfTheListReachesFull() {
		testList.full = 1;
		testList.AddCard(testCardTwo);
		Assert.AreEqual(true, testList.IsFull());
	}

	[Test]
	public void SizeReturnsTheCurrentSizeOfTheList() {
		Assert.AreEqual(0, testList.Size());
		testList.AddCard(testCardTwo);
		Assert.AreEqual(1, testList.Size());
	}

	[Test]
	public void RemoveCardReturnsTheCardFromList() {
		testList.AddCard(testCardOne);
		testList.AddCard(testCardTwo);
		Assert.AreEqual (2, testList.Size ());
		Assert.AreEqual(testCardTwo, testList.RemoveCard(1));
		Assert.AreEqual(1, testList.Size ());
	}

	[Test]
	public void RemovingACardThatDoesntExistReturnsNull() {
		testList.AddCard(testCardOne);
		Assert.AreEqual(null, testList.RemoveCard(3));
	}

}
