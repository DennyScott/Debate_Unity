using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
[Category("Base Card Tests")]
public class CardTest {
	Card testCard;
	Player testPlayer;
	readonly string playerName = "Andy";
	readonly string name = "Common";

	[SetUp]
	public void Init() {
		testPlayer = new Player(playerName);
		testCard = new Card(testPlayer, name);
	}

	[Test]
	public void OwnerReturnsPlayerObject() {
		Assert.AreEqual(testPlayer, testCard.owner);
	}

	[Test]
	public void SettingOwnerChangePlayerObject() {
		Player tempPlayer = new Player("Jimmy");
		testCard.owner = tempPlayer;
		Assert.AreEqual(tempPlayer, testCard.owner);
	}

	[Test]
	public void GetTextReturnsTextPassed() {
		Assert.AreEqual(name, testCard.name);
	}

	[Test]
	public void SettingTextChangesName() {
		string newWord = "Hello";
		testCard.name = newWord;
		Assert.AreEqual(newWord, testCard.name);
	}
}
