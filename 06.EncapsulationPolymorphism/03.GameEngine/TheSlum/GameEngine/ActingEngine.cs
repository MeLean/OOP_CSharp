using System;
using TheSlum;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _03.GameEngine.TheSlum;

namespace TheSlum.GameEngine
{
    public class ActingEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create":
                    CreateCharacter(inputParams);
                    break;
                case "add":
                    AddItem(inputParams);
                    break;
                default:
                    base.ExecuteCommand(inputParams);
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            Character newCharacter;
            switch (inputParams[1].ToLower())
            {
                case "warrior":
                    newCharacter = new Warrior(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        (Team)Enum.Parse(typeof(Team), inputParams[5], true));
                    this.characterList.Add(newCharacter);
                    break;

                case "mage":
                   newCharacter = new Mage(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        (Team) Enum.Parse(typeof (Team), inputParams[5], true));
                    this.characterList.Add(newCharacter);
                    break;

                case "healer":
                    newCharacter = new Healer(
                        inputParams[2],
                        int.Parse(inputParams[3]),
                        int.Parse(inputParams[4]),
                        (Team) Enum.Parse(typeof (Team), inputParams[5], true));
                    this.characterList.Add(newCharacter);
                    break;

                default:
                    throw new ApplicationException("Character: " + inputParams[1] + " can not be created!");
            }
        }

        protected new void AddItem(string[] inputParams)
        {
            
            switch (inputParams[2])
            {
                case "axe":
                    //// Axe – Item with HealthEffect of 0, DefenseEffect of 0 and AttackEffect of 75.
                    GetCharacterById(inputParams[1]).AddToInventory(new ActiongItem(inputParams[3], 0, 0, 75));
                    break;

                case "shield":
                    //// Shield – Item with HealthEffect of 0, DefenseEffect of 50 and AttackEffect of 0.
                    GetCharacterById(inputParams[1]).AddToInventory(new ActiongItem(inputParams[3], 0, 50, 0));
                    break;

                case "injection":
                    //// Injection – Bonus item with HealthEffect of 200 for 3 turns. If a character's health points fall 
                    GetCharacterById(inputParams[1]).AddToInventory(new Injection(inputParams[3], 200, 0, 0));
                    break;

                case "pill":
                    //// Pill – Bonus item with AttackEffect of 100 for 1 turn.
                    GetCharacterById(inputParams[1]).AddToInventory(new Pill(inputParams[3], 0, 0, 100));
                    break;

                default:
                    throw new ApplicationException("Ithem: " + inputParams[3] + " can not be added!");
            }
        }
    }
}
