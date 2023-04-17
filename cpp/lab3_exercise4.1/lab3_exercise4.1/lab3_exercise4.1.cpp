
#include <iostream>
#include <string>

using namespace std;

int addNumders(int);
int addNumders(int, int);

int main()
{
	system("chcp 1251");
	int firstNumber, secondNumber;
	cout << "Введите первое число: " << endl;
	cin >> firstNumber;

	//int addNumders(int);
	cout << "Сумма чисел: " << addNumders(firstNumber) << endl;

	cout << "Введите второе число: " << endl;
	cin >> secondNumber;

	//int addNumders(int, int);
	
	cout << "Сумма чисел в интервале между " << firstNumber << " и " << secondNumber << " равна: "  << addNumders(firstNumber, secondNumber) << endl;
	
}

int addNumders(int n)
{
	if (n == 1) return 1;
	else return (n + addNumders(n - 1));
}

int addNumders(int n, int c)
{
	if (n == c) return c;
	else {
		return (c + addNumders(n, (c - 1)));
	}
}


