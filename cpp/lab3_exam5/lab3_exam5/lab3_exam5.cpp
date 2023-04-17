#include <iostream>
#include <cmath>
using namespace std;

void converter(int number)
{
	if (number < 2)
	{
		cout << number;
		return;
	}

	else
	{
		converter(number / 2);
		cout << number % 2;
		return;
	}
}

int main()
{
	system("chcp 1251");

	int n;
	cout << "Введите число для перевода в двоичную систему: " << endl;
	cin >> n;
	cout << "Итог: "; 
	converter(n);
}

