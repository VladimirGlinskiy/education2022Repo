#include <iostream>
using namespace std;

struct Time
{
    int hours;
    int minutes;
    int seconds;

    int sec(int hours, int minutes, int seconds)
    {
        int s = (hours * 3600) + (minutes * 60) + seconds;
        return s;
    }

    void sumTime(Time t)
    {
        int firstSec = sec(t.hours, t.minutes, t.seconds);
        int secondSec = sec(hours, minutes, seconds);
        int sumSeconds = firstSec + secondSec;
     cout << "Суммарное количество секунд: " << sumSeconds << endl; 
         
    }

    void subTime(Time t)
    {
        
        int firstSec = sec(t.hours, t.minutes, t.seconds);
        int secondSec = sec(hours, minutes, seconds);
        int sumSeconds = firstSec - secondSec;
        cout << "Разница между интервалами в секундах: " << sumSeconds << endl;

    }

};

Time InputTime()
{
    Time t;

    cout << "Введите часы: ";
    cin >> t.hours;
    cout << "Введите минуты: ";
    cin >> t.minutes;
    cout << "Ввдите секунды: ";
    cin >> t.seconds;

    return t;
}

int main()
{
    system("chcp 1251");

    cout << "Введите параметры первого интервала времени: " << endl;
    Time t1 = InputTime();
    cout << "Введите параметры второго интервала времени: " << endl;
    Time t2 = InputTime();
    t2.sumTime(t1);
    t2.subTime(t1);

}