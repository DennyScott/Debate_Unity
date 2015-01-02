using UnityEngine;
using System.Collections;
using NUnit.Framework;


[TestFixture]
[Category("Stone Tests")]
public class StoneTest {

	Player testPlayer;
	string name;
	Stone testStone;

	[SetUp]
	public void Init() {
		testPlayer = new Player("Andy");
		name = "Player";
		testStone = new Stone(testPlayer, name);
	}

	[Test]
	public void DefaultColorIsNone() {
		Assert.AreEqual(StoneColor.NONE, testStone.color);
	}

	[Test]
	public void SettingColor() {
		testStone.color = StoneColor.BLUE;
		Assert.AreEqual(StoneColor.BLUE, testStone.color);
	}
}
