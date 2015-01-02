using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
[Category("Command Tests")]
public class CommandTest {

	Player testPlayer;
	string name;
	Command testCommand;

	[SetUp]
	public void Init() {
		testPlayer = new Player("Andy");
		name="Command";
		testCommand = new Command(testPlayer, name);
	}

	[Test]
	public void CreatingCommandAddsAppropriateOwnerAndText() {
		Assert.AreEqual(testPlayer, testCommand.owner);
		Assert.AreEqual(name, testCommand.name);
	}

	[Test]
	public void CostReturnsTheDefaultCost() {
		Assert.AreEqual(CommandConstants.DEFAULT_COMMAND_COST, testCommand.cost);
	}

	[Test]
	public void DescriptionReturnstheDefaultDescription() {
		Assert.AreEqual(CommandConstants.DEFAULT_COMMAND_DESCRIPTION, testCommand.description);
	}

	[Test]
	public void SettingCostChangesCost() {
		testCommand.cost = 10;
		Assert.AreEqual(10, testCommand.cost);
	}

	public void SettingDescription() {
		testCommand.description = "test";
		Assert.AreEqual("test", testCommand.description);
	}
}
