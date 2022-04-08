using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VladimirGlinskii.devFundamentals.consoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prepare data
            Match[] arr = new Match[3];
            arr[0] = new Match(101, "Neva", "Yalta", 2, 1);
            arr[1] = new Match(102, "Neva", "Kirov", 1, 3);
            arr[2] = new Match(103, "Minsk", "Sever", 0, 0);

            //Start program
            program(arr); 

        }

        //Main program flow
        public static void program(Match[] arr) {

            Match match = chooseMatch(arr);

            int[] predictedResult = new int[2];

            Console.Clear();
            Console.WriteLine("Введите результат команды " + match.firstTeamName);
            predictedResult[0] = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите результат команды " + match.secondTeamName);
            predictedResult[1] = Int32.Parse(Console.ReadLine());

            int[] realResult = new int[2];
            realResult[0] = match.firstTeamScore;
            realResult[1] = match.secondTeamScore;

            showResult(predictedResult, realResult);
            exit(arr);

        }

        public static Match chooseMatch(Match[] array)
        {

            Match choosenMatch = null;
            Console.WriteLine("Выберите матч на который хотите сделать ставку \n");

            foreach (Match i in array)
            {
                Console.WriteLine("Для выбора матча: \"" + i.firstTeamName + "-" + i.secondTeamName + "\"" + " введите код: " + i.matchID);
            }

            String MatchID = Console.ReadLine();

            foreach (Match i in array) {

                if (i.matchID == Int32.Parse(MatchID)) {
                    choosenMatch = i;
                }
            }

            if (choosenMatch == null) {
                Console.WriteLine("Введенный ID матча некорректен.");
                exit(array);
            }

            return choosenMatch; 
        }

        public static void showResult(int[] predictedResult, int[] realResult) {
            int numberOfTeams = 2;
            int guessedValues = 0;

            for (int i = 0; i < numberOfTeams; i++) {
                if (predictedResult[i] == realResult[i]) {
                    guessedValues += 1; 
                } 
            }

            if (guessedValues == 2) {
                Console.WriteLine("\nВы угадали результат игры. Вы выиграли");
                    }
            else {
                Console.WriteLine("\nРезультат игры отличается.\nКоманды сыграли со счетом "+ realResult[0]+":"+realResult[1] + "\nВы проиграли");
            }
        
        }

        public static void exit(Match[] arr) {
            Console.WriteLine("\nЧтобы сыграть еще раз введите y \nДля выхода введите любое другое значение");
   
            if (Console.ReadLine() == "y") 
                    {
                Console.Clear();
                program(arr);
                }
            else { 
                Environment.Exit(2128506);
            }
        }
    }

     class Match {

        public int matchID;

        public string firstTeamName;
        public string secondTeamName;

        public int firstTeamScore;
        public int secondTeamScore;  

        public Match(int matchID, string firstTeamName, string secondTeamName, int firstTeamScore, int secondTeamScore) { 
            this.matchID = matchID;
            this.firstTeamName = firstTeamName;
            this.secondTeamName = secondTeamName;
            this.firstTeamScore = firstTeamScore;
            this.secondTeamScore = secondTeamScore;
        }
    }
}
