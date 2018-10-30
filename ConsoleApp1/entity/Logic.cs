using ConsoleApp1.boundary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.entity
{
    class Logic
    {
        private int round = 0;
        private int winningScore = 1;
        private int[] scoreList;
        private int pNum = InputValidator.getPlayerNum();
        private Dice dice = new Dice();
        private int winnerScore;

        public Logic()
        {
            game();
        }


        private Boolean gameOver()
        {
            for (int i = 0; i < pNum; i++)
            {
                if (scoreList[i] >= winningScore)
                {
                    return true;
                }
            }
            return false;
        }

        private void scoreCheck()
        {
            int index = 0;
            for (int i = 0; i < scoreList.Length; i++)
            {
                if (scoreList[i] > scoreList[index])
                {
                    index = i;
                }
            }
            winnerScore = scoreList[index];
            if (isTie())
            {
                print("There is a tie");
            }
            else
            {
                //announceTheWinner();
                print(TextClss.winGameMesg + InputValidator.getPlayerNames()[index]);
            }
        }

        private void announceTheWinner()
        {




            /* Dette virker også
            int index = 0;
            for (int i = 0; i < scoreList.length; i++) {
                index = scoreList[i] > scoreList[index] ? i : index;
            }*/
        }


        private void game()
        {
            scoreList = new int[pNum];

            do
            {

                round++;
                print(TextClss.roundShow(round));

                for (int i = 0; i < pNum; i++)
                {
                    dice.roll();
                    scoreList[i] += dice.getTotal();
                    // System.out.println(GameController.getPlayerNames()[i] + " :" + scoreList[i]);
                    print(TextClss.scoreShow(InputValidator.getPlayerNames()[i], scoreList[i]));
                }
                gameOver();
                print(TextClss.sepGameLine);
            } while (!gameOver());
            scoreCheck();


        }

        private Boolean isTie()
        {
            int count = 0;
            for (int i = 0; i < scoreList.Length; i++)
            {
                if (scoreList[i] == winnerScore)
                {
                    count++;
                }
            }
            if (count > 1)
            {
                return true;
            }
            return false;
        }

       private void print(String word)
        {
            Console.WriteLine(word);
        }
    }
}
