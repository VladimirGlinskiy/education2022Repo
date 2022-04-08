using System;
namespace examAssignment
{
    internal class TemperatureMeasurment
    {
        static void Main(string[] args)
        {
            String exit; 

            do
            {
                int FINISH = 99999;

                //В блок-схеме "maxTemperature" указана как "Max", "minTemperature" указана как "Min"
                int maxTemperature = -9999;
                int minTemperature = 9999;

                Console.Clear();
                Console.WriteLine("Сеанс начат. Введите значение температуры. \nДля окончания сеанса введите 99999");

                //Переменная "T" переименована в "measurment" для удобства чтения
                int measurment = Int32.Parse(Console.ReadLine());


                while (measurment != FINISH)
                {
                    if (measurment > maxTemperature)
                    {
                        maxTemperature = measurment;
                    }

                    if (measurment < minTemperature)
                    {
                        minTemperature = measurment;
                    }
                    Console.Clear();

                    //Добавлен промежуточный вывод данных для явного отображения работы алгоритма
                    Console.WriteLine("Данные учтены. Промежуточные значения температуры:\nМинимальная: "
                        + minTemperature + "\nМаксимальная: " + maxTemperature
                        + "\nДля окончания сеанса введите 99999\nДля продолжения введите следующее значение ");

                    measurment = Int32.Parse(Console.ReadLine());
                }
                Console.WriteLine("\nСеанс окончен. \nЗначение минимальной температуры: " + minTemperature
                    + "\nЗначение максимальной температуры: " + maxTemperature);

                Console.WriteLine("Чтобы закрыть программу введите y");
                exit = Console.ReadLine(); 

            }
            while (exit!="y"); 
        }
       
    }
}
