﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Game
    {
        private bool _gameOver = false;
        
        

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

        

        private void Start()
        {
            Character Player = new Player();
          Character[] EnemyArray = new Enemy[3];
            EnemyArray[0] = new Enemy();
            EnemyArray[1] = new Enemy();
            EnemyArray[2] = new Enemy();





            

        }

        private void Update()
        {

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
