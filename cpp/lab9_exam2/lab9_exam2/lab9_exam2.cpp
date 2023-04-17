
#include <iostream>
using namespace std;

class IncorrectData
{
public:
	IncorrectData() : message("Введенные данные некорректны") { };
	void printMessage() const { cout << message << endl; };
private:
	string message;
};

class Time
{
public:
	Time() : m_hours(0), m_minutes(0), m_seconds(0) {}

	Time(int hours, int minutes, int seconds)
		: m_hours(hours), m_minutes(minutes), m_seconds(seconds) {

		timeCheсk(hours, minutes, seconds);
		m_hours = hours;
		m_minutes = minutes;
		m_seconds = seconds;
	}

	friend void timeVisible(Time& t)
	{
		cout << "Результат сложения: " << t.m_hours << ":" << t.m_minutes << ":" << t.m_seconds << endl;
	}

	Time timeAdded(const Time& t)
	{
		Time time;
		time.m_hours = m_hours + t.m_hours;
		time.m_minutes = m_minutes + t.m_minutes;
		time.m_seconds = m_seconds + t.m_seconds;

		timeCheсk(time.m_hours, time.m_minutes, time.m_seconds);

		return time;
	}

private:
	int m_hours;
	int m_minutes;
	int m_seconds;

	void timeCheсk(int& hours, int& minutes, int& seconds)
	{
		if (hours < 0 || minutes < 0 || seconds < 0)
			throw IncorrectData();

		if (seconds > 60)
		{
			int tmpMins = seconds / 60;

			minutes += tmpMins;
			seconds -= tmpMins * 60;
		}

		if (minutes > 60)
		{
			int tmpHours = minutes / 60;

			hours += tmpHours;
			minutes -= tmpHours * 60;
		}
	}
};

int main()
{
	system("chcp 1251");
	int hours, minutes, seconds;
       
	cout << "Введите часы, минуты, секунды первого интервала:\n";
	cin >> hours >> minutes >> seconds;
	Time time1(hours, minutes, seconds);

	cout << "Введите часы, минуты, секунды второго интервала:\n";
	cin >> hours >> minutes >> seconds;

	try
	{
		Time time2(hours, minutes, seconds);  
		Time time3 = time1.timeAdded(time2);
		timeVisible(time3);
	}
	catch (IncorrectData& error)
	{
		cout << "error: ";
		error.printMessage();
	}

}