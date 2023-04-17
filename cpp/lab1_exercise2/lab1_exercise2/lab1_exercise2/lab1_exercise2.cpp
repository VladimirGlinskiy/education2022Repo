#include <iostream>

using namespace std;

int main()
{
    system("chcp 1251");
    double a, b;
    cout << "Введите a и b: \n";
    cin >> a;
    cin >> b;
    double x = a / b;
    cout.precision(3);
    cout << "\nx = " << x << endl;
    cout << sizeof(a / b) << ends << "\n" << sizeof(x) << endl;
    return 0;

}
