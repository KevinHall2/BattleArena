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
        
        
        //function for decisions in a fight
        private int BattleDecisionInput(string description, string option1, string option2)
        {
            ConsoleKeyInfo key;

            int inputRecieved = 0;

            while (inputRecieved != 1 && inputRecieved != 2)
            {

                Console.Clear();
                Console.WriteLine(description);
                Console.WriteLine("1: ");
                Console.WriteLine("2: ");
                Console.Write(">");

                key = Console.ReadKey();

                if (key.KeyChar == '1')
                {
                    inputRecieved = 1;

                }
                else if (key.KeyChar == '2')
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
            Console.Clear();
            Console.WriteLine(storyText);
            Console.WriteLine("<<Press any key to continue.>>");
            Console.ReadKey();
            return storyText;
        }



        private void Start()
        {
            //declaring enemies and player
            Character Player = new Player();
          Character[] EnemyArray = new Enemy[3];
            EnemyArray[0] = new Enemy();
            EnemyArray[1] = new Enemy();
            EnemyArray[2] = new Enemy();

            //exposition
            GetStoryText("You enter a clearing in the Deep Caverns where your hunting mark lies: the foul Hydra. " +
                "\nIt raises its six heads and bares its teeth as you approach it, and you draw your sword for the fight.");   

        }

        private void Update()
        {
            int input = BattleDecisionInput("You and the Hydra slowly circle each other in a staredown. What do you do?", "Attack", "Recover");
            

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
