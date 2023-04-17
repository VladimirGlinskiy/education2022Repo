#pragma once
using namespace std;

class Time
{
public:
	Time();
	Time(int, int, int);
	Time(int);
	int getHours();
	int getMinutes();
	int getSeconds();
	void setTime(int, int, int);
	void showTime() const;
	void convertTime();
	Time sumTime(Time) const;
	Time operator+(const Time& t);
	Time operator-(const Time& t);
	bool operator>(const Time& t);
	bool operator<(const Time& t);
	Time operator+ (int n);
	Time operator- (int n);
	friend Time operator+ (const Time& t, int n);
	friend Time operator- (const Time& t, int n);
	operator int() const;

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