#include <iostream>
#include <cmath>
#include <tuple>
using namespace std;

using Tuple = tuple <double, double, int>;

Tuple Root(double a, double b, double c)
{
	double x1 = 0, x2 = 0;
	int flag = -1;
	double d = (b * b) - (4 * a * c);

	if (d > 0)
	{
		x1 = ((-b) + sqrt(d)) / (2 * a);
		x2 = ((-b) - sqrt(d)) / (2 * a);
		flag = 1;
	}
	if (d == 0)
	{
		x1 = (-b) / (2 * a);
		x2 = x1;
		flag = 0;
	}

	return make_tuple(x1, x2, flag);
}

int main()
{
	system("chcp 1251");

	double a, b, c;

	cout << "Введите коэффициенты квадратного уравнения" << endl;
	cin >> a >> b >> c;

	Tuple r = Root(a, b, c);
	cout << "x1 = " << get<0>(r) << endl;
	cout << "x2 = " << get<1>(r) << endl;
	cout << "Наличия корней: " << get<2>(r) << endl;

}