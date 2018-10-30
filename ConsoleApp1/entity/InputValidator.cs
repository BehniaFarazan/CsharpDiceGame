using ConsoleApp1.boundary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.entity
{
    class InputValidator
    {

        public InputValidator()
        {
            welcomeMs();
        }

        public static int getPlayerNum()
        {
            return playerNum;
        }

        public static String[] getPlayerNames()
        {
            return playerNames;
        }

        private static int playerNum;
        private static String[] playerNames;


         public void welcomeMs()
        {
            try
            {
                print(TextClss.welcMesg);
                print(TextClss.playernumMesg);
                //   Scanner scanner = new Scanner(System.in);
                // playerNum = scanner.nextInt();
                //playernum = Console.ReadLine();
                playerNum = Convert.ToInt32(Console.ReadLine());
        
                playerNames = new String[playerNum];
                print(TextClss.playerNumber(playerNum));
                print(TextClss.sepMesgLine);
                int counter = 0;
                for (int i = 0; i < playerNum; i++)
                {
                    counter++;
                    print(TextClss.nameThePlayer(counter));
                    String name = Console.ReadLine();
                    playerNames[i] = name;
                    print(TextClss.sepMesgLine);
                }

            }
            catch (Exception exp)
            {
                print("Forkert input");
                welcomeMs();
            }
        }

        private void print(String word)
        {
            Console.WriteLine(word);
        }
    }
}
