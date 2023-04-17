#include <iostream> 
using namespace std;

int main()
{
	system("chcp 1251");
	int a;
	cout << "Введите число = "; cin >> a;

	for (int i = 2; i <= a / 2; i++)
	{
		if (a % i == 0)
		{
			cout << "Введенное число не является простым" << endl;
			return 0;
		}
	}
	cout << "Введенное число простое" << endl;
	return 0;
}