#include <iostream>
#include "Time.h"
using namespace std;

int main()
{
	system("chcp 1251");
	int h, m, s;

	try {
		cout << "�������: ����, ������, �������: " << endl;
		if (!(cin >> h >> m >> s))
			throw Time::NumberErr();

		Time const time = Time(h, m, s);
		time.showTime();
	}
	catch (Time::NumberErr& ex)
	{
		ex.printMessage();
	}
}