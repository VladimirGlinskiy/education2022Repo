#include <iostream>
#include "Time.h"
using namespace std;

int main()
{
	system("chcp 1251");

	int h, m, s;

	try {
		cout << "Введите: часы, минуты, секунды первого интервала времени: " << endl;
		if (!(cin >> h >> m >> s))
			throw Time::NumberErr();

		Time t1 = Time(h, m, s);

		cout << "Введите: часы, минуты, секунды второго интервала времени: " << endl;
		if (!(cin >> h >> m >> s))
			throw Time::NumberErr();

		Time t2 = Time(h, m, s);


		Time t3 = t1 + t2;
		Time t4 = t1 - t2;
		


		cout << "Результат сложения : " << endl;
		t3.showTime();
		cout << "Результат вычитания: " << endl;
		t4.showTime();
	

		cout << "\nCложение объекта Time и переменной вещественного типа. Введите переменную:  " << endl;
		
		int c;
		cin >> c;

		Time t5 = c + t1;
		Time t6 = t1 + c;


		t5.showTime();
		t6.showTime();

	}
	catch (Time::NumberErr& ex)
	{
		ex.printMessage();
	}

}