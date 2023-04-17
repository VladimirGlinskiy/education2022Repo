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

Time::Time(int s)
{
	Time::setTime(0, 0, s);
}

void Time::convertTime()
{
	while (seconds >= 60)
	{
		seconds -= 60;
		minutes++;
	}

	while (minutes >= 60)
	{
		minutes -= 60;
		hours++;
	}

	while (hours > 24)
	{
		hours -= 24;
	}

	while (seconds < 0)
	{
		seconds += 60;
		minutes--;
	}

	while (minutes < 0)
	{
		minutes += 60;
		hours--;
	}
	while (hours < 0)
	{
		hours += 24;
	}
}

void Time::setTime(int h, int m, int s)
{
	hours = h;
	minutes = m;
	seconds = s;

	Time::convertTime();
}

int Time::getHours() { return hours; };
int Time::getMinutes() { return minutes; };
int Time::getSeconds() { return seconds; };

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

Time::operator int() const
{
	return seconds + (minutes * 60) + (hours * 60 * 60);
}

Time Time::operator+(const Time& t)
{
	return Time(this->hours + t.hours, this->minutes + t.minutes, this->seconds + t.seconds);
}

Time Time::operator-(const Time& t)
{
	return Time(this->hours - t.hours, this->minutes - t.minutes, this->seconds - t.seconds);
}

bool Time::operator>(const Time& t)
{
	if (this->hours > t.hours) return true;
	else if (this->hours == t.hours && this->minutes > t.minutes) return true;
	else if (this->hours == t.hours && this->minutes == t.minutes && this->seconds > t.seconds) return true;
	else return false;
}

bool Time::operator<(const Time& t)
{
	if (this->hours < t.hours) return true;
	else if (this->hours == t.hours && this->minutes < t.minutes) return true;
	else if (this->hours == t.hours && this->minutes == t.minutes && this->seconds < t.seconds) return true;
	else return false;
}

Time Time::operator+ (int s)
{
	s += int(this);
	return Time(s);
}

Time Time::operator- (int s)
{
	s -= int(this);
	return Time(s);
}

Time operator+ (Time& t, int n)
{
	return Time(t.getHours(), t.getMinutes(), t.getSeconds() + n);
}

Time operator- (Time& t, int n)
{
	return Time(t.getHours(), t.getMinutes(), t.getSeconds() - n);
}