#include <iostream>
#include <math.h>
using namespace std;


int main()
{
	system("chcp 1251");
	int a, b; //temp удалил как неиспользуемую 
	cout << "a = "; cin >> a;
	cout << "b = "; cin >> b;

	while (a != b)
	{
		if (a > b)
			a -= b;
		else
			b -= a;
	}

	cout << "Наибольший общий делитель = " << a << endl;
}
