#pragma once
using namespace std;

class Time
{
public:
	Time();
	Time(int, int, int);
	void setTime(int, int, int);
	void showTime() const;
	void convertTime();
	Time sumTime(Time) const;

	class NumberErr {
	public:
		NumberErr() : message("Ошибка ввода целых чисел") { }
		void printMessage() const { cout << message << endl; }
	private:
		string message;

	};

private:
	int hours;
	int minutes;
	int seconds;
};