using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Game
    {
        private bool _gameOver = false;

        //declaring array for the enemies the player will fight
        private Character[] _enemyArray;

        //declaring the player that will fight the Hydra
        private Character _player = new Player();


        //function for decisions in a fight
        private int BattleDecisionInput(string description, string option1, string option2)
        {
            string input = "";
            int inputRecieved = 0;

            while (inputRecieved != 1 && inputRecieved != 2)
            {


                Console.WriteLine(description);
                Console.WriteLine("1: " + option1);
                Console.WriteLine("2: " + option2);
                Console.Write(">");

                input = Console.ReadLine(); 

                if (input == "1" || input == option1)
                {
                    inputRecieved = 1;
                }
                else if (input == "2" || input == option2)
                {
                    inputRecieved = 2;
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                    Console.ReadKey();
                }

            }
            Console.WriteLine();
            return inputRecieved;
        }

        //function for dialogue and exposition
        private string GetStoryText(string storyText)
        {
            Console.WriteLine(storyText);
            Console.WriteLine("<<Press any key to continue.>>");
            Console.ReadKey();
            Console.Clear();
            return storyText;
        }



        private void Start()
        {
            //declaring enemies and player
            
            _enemyArray = new Enemy[3];
            _enemyArray[0] = new Enemy();
            _enemyArray[1] = new Enemy();
            _enemyArray[2] = new Enemy();

            //exposition
            GetStoryText("You enter a clearing in the Deep Caverns where your hunting mark lies: the foul Hydra. " +
                "\nIt raises its six heads and bares its teeth as you approach it, and you draw your sword for the fight.");   

        }

        private void Update()
        {
            Console.WriteLine("Your health: " + _player.Health + "/" + _player.MaxHealth);

            //if statement that shows different enemy index health values based on the hydra heads remaining
            if (_enemyArray[0].HeadsRemaining == 6)
            {
               Console.WriteLine("The Hydra's health: " + _enemyArray[0].Health + "/" + _enemyArray[0].MaxHealth);
                 
            }
            else if (_enemyArray[0].HeadsRemaining == 4)
            {
               Console.WriteLine("The Hydra's health: " + _enemyArray[1].Health + "/" + _enemyArray[1].MaxHealth);
               
            }
            else if (_enemyArray[0].HeadsRemaining == 2)
            {
               Console.WriteLine("The Hydra's health: " + _enemyArray[2].Health + "/" + _enemyArray[2].MaxHealth);
            }


            int input = BattleDecisionInput("You and the Hydra slowly circle each other in a staredown. What do you do?", "Attack", "Recover");
            if (input == 1)
            {
                _player.Attack(_enemyArray[0]);
            }
            else if (input == 2)
            {
                _player.Heal(10);
            }

        }

        private void End()
        {

        }


        public void Run()
        {
            Start();
            while (!_gameOver)
            {
                Update();
            }
            End();
        }
    }
}
