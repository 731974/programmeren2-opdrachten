using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DoorGame
{
    public class Game
    {
        private int correctDoor;

        List<int> doors = new List<int>();

        public Game()
        {
            //Step 1 | Select random door (1-3)
            Random rnd = new Random();
            correctDoor = rnd.Next(1, 4);

            for (int i = 0; i < 3; i++)
            {
                {
                    if (i == correctDoor - 1)
                        doors.Add(1);
                    else
                        doors.Add(0);
                }
            }


            //Step 2 | Ask user for a random door (1-3)
            int userInput = AskUserForRandomNumber();


            //Step 3 | Check wheter user input is the correct number and print out a random door (wrong)
            int randomWrongDoor = 0;

            if(IsCorrectDoor(userInput, doors))
                randomWrongDoor = ChooseRandomWrongDoor(doors, userInput);
            else
            {
                randomWrongDoor = ChooseOneWrongDoor(doors, userInput);
            }


            //Step 4 | Open a random wrong door
            Console.WriteLine($"Door {randomWrongDoor} is wrong");


            //Step 5 | Ask user if they want to switch doors
            int door = GetOtherDoor(userInput, doors, randomWrongDoor);

            if (UserWantsToSwitch(door))
                userInput = door;


            //Step 6 | Open selected door
            if (IsCorrectDoor(userInput))
            {
                Console.WriteLine("congrutations you win!");
            }
            else
            {
                Console.WriteLine("you loose");
                Console.WriteLine($"The correct door was {correctDoor}");
            }
        }

        int GetOtherDoor(int userDoor, List<int> doors, int randomDoor)
        {
            int callback = 0;

            for (int i = 0; i < doors.Count; i++)
            {
                if (i+1 != randomDoor && i+1 != userDoor)
                    callback = i+1;
            }

            return callback;
        }

        bool IsCorrectDoor(int i)
        {

            return i == correctDoor;
        }

        bool UserWantsToSwitch(int door)
        {
            Console.Write($"Do you want to switch to door {door}? (Yes/No) ");

            YesNo input = (YesNo)Enum.Parse(typeof(YesNo), Console.ReadLine());

            if (input == YesNo.Yes)
                return true;
            return false;
        }

        int ChooseOneWrongDoor(List<int> doors, int user)
        {
            int response = 0;


            for (int i = 0; i < doors.Count; i++)
            {
                if (i + 1 != user && doors[i] != 1)
                    response = i + 1;
            }

            return response;
        }

        int ChooseRandomWrongDoor(List<int> doors, int user)
        {
            List<int> wrongDoorList = new List<int>();

            foreach (int i in doors) {

                if (i == 0)
                {
                    wrongDoorList.Add(i + 1);
                }
            }

            Random rnd = new Random();
            return wrongDoorList[rnd.Next(1, wrongDoorList.Count())];
        }

        bool IsCorrectDoor(int input, List<int> doors)
        {
            if (doors[input-1] == 1)
                return true;
            else
                return false;
        }
      
        int AskUserForRandomNumber()
        {
            Console.Write("Enter a random doornumber (1-3): ");
            return int.Parse(Console.ReadLine());
        }

        //Utils for testing
        void DisplayList(List<int> list)
        {
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
