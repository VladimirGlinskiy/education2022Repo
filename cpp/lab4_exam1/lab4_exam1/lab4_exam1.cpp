#include <iostream>
#include <cmath>

using namespace std;
int Myroot(double a, double b, double c, double& x1, double& x2)
{
	double discriminant = b * b - 4 * a * c;

	if (discriminant > 0)
	{
		x1 = ((-b) + sqrt(discriminant)) / (2 * a);
		x2 = ((-b) - sqrt(discriminant)) / (2 * a);
		return 1;
	}
	else if (discriminant == 0)
	{
		x1 = (-b) / (2 * a);
		x2 = x1;
		return 0;
	}
	else if (discriminant < 0)
	{
		return -1;
	}
}

int main()
{

	system("chcp 1251");

	double a, b, c, x1 = 0, x2 = 0;

	cout << "Введите коэфиценты квадратного уравнения: ";
	cin >> a >> b >> c;

	switch (Myroot(a, b, c, x1, x2))
	{
	case(1):
		cout << "Уравнение имеет два корня: " << "x1 = " << x1 << ", x2 = " << x2 << endl;
		break;
	case(0):
		cout << "«Корень уравнения один x1 = x2 = " << x1 << endl;
		break;
	case(-1):
		cout << "Корней уравнения нет" << endl;
		break;
	}
}