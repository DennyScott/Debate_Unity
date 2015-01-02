using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityTest;
using NUnit.Framework;

[TestFixture]
[Category("Player Tests")]
public class PlayerTest {
	Player testPlayer;
	readonly string playerName = "Andy";

	[SetUp]
	public void Init(){
		testPlayer = new Player(playerName);
	}

	[Category("Players Health")]
	[Test]
	public void PlayersStartingHealthIsWhatsDefinedInGeneralConstants() {
		CardList t = new CardList();
		Deck d = new Deck();
		Hand h = new Hand();
		Assert.AreEqual(GeneralConstants.STARTING_HEATH, testPlayer.health);
	}

	[Test]
	public void ManuallySettingPlayersHealthChangesHealthToThatValue() {
		int newHealth = 100;
		testPlayer.health = newHealth;
		Assert.AreEqual(newHealth, testPlayer.health);
	}

	[Test]
	public void RemoveHealthRemovesValueFromHealth() {
		int expectedHealth = testPlayer.health - 5;
		Assert.AreEqual(expectedHealth, testPlayer.RemoveHealth(5));
	}

	[Category("Players Name")]
	[Test]
	public void RetrievingThePlayersNameReturnsStringOfName() {
		Assert.AreEqual(playerName, testPlayer.name);
	}

	[Test]
	public void ManuallySettingNameChangesNameToSetValue() {
		string newName = "Jimmy";
		testPlayer.name = newName;
		Assert.AreEqual(newName, testPlayer.name);
	}

	[Category("Status Effects")]
	public void getListOfStatusEffects() {
		Assert.AreEqual(0, testPlayer.statusEffects.Count);
		Assert.IsTrue(testPlayer.statusEffects is List);
	}

}
