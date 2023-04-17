
#include <iostream>
using namespace std;

int main()
{
	system("chcp 1251");
	int a, b;
	cout << "a = "; cin >> a;
	cout << "b = "; cin >> b;

	do
	{
		if (a > b)
			a -= b;
		else
			b -= a;
	} while (a != b);

	cout << "Наибольший общий делитель = " << a << endl;
}
