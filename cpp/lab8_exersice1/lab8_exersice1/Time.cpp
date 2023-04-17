#include <iostream>
#include <string>
#include <fstream>
#include "Time.h"
using namespace std;

Time::Time()
{
	int hours = 0;
	int minutes = 0;
	int seconds = 0;
}

Time::Time(int h, int m, int s)
{
	Time::setTime(h, m, s);
}

void Time::convertTime()
{
	while (minutes >= 60)
	{
		minutes -= 60;
		hours++;
	}

	while (seconds >= 60)
	{
		seconds -= 60;
		minutes++;
	}

	while (hours >= 24)
	{
		hours -= 24;
	}
}

void Time::setTime(int h, int m, int s)
{
	hours = h;
	minutes = m;
	seconds = s;

	Time::convertTime();
}

void Time::showTime() const
{
	cout << hours << " : " << minutes << " : " << seconds << endl;
}

Time Time::sumTime(Time t) const
{
	t.hours = hours + t.hours;
	t.minutes = minutes + t.minutes;
	t.seconds = seconds + t.seconds;

	t.convertTime();

	return t;
}