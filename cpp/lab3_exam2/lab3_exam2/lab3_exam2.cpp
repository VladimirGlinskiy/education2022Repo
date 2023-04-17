#include <iostream>
#include <cmath>
using namespace std;

double cubeRoot(double number)
{
    return pow(number, 1.0 / 3);
}

double cubeRootIterable(double number)
{
    double rootResult = number;
    double x = 0;

    while (abs(x - rootResult) > 0.001) {
        x = rootResult;
        rootResult = (number / (x * x) + 2 * x) / 3;
    }
    return rootResult;

}

int main()
{
    
	system("chcp 1251");

    double userNumber;
    cin >> userNumber;
    cout << "Обычная формула: "  << cubeRoot(userNumber) << endl;
    cout << "Итерационная функция: " << cubeRootIterable(userNumber);

}