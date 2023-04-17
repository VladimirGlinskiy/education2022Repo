#include <iostream>
#include <cmath>
using namespace std;

struct Root
{
    double x1 = 0;
    double x2 = 0;

    void showRoots()
    {
        cout << "Корень x1 = " << x1 << endl;
        cout << "Корень x2 = " << x2 << endl;
    }

};

struct Coefficients
{
    double a;
    double b;
    double c;
};

Coefficients inputCoeff()
{
    Coefficients coeff;

    cout << "Введите a: ";
    cin >> coeff.a;
    cout << "Введите b: ";
    cin >> coeff.b;
    cout << "Ввдите c: ";
    cin >> coeff.c;

    return coeff;
}

Root extract(Coefficients coef)
{
    Root r;

    double d = (coef.b * coef.b) - (4 * coef.a * coef.c);

    if (d > 0)
    {
        r.x1 = (-(coef.b) + sqrt(d)) / (2 * coef.a);
        r.x2 = (-(coef.b) - sqrt(d)) / (2 * coef.a);
    }

    if (d == 0)
    {
        r.x1 = -(coef.b) / (2 * coef.a);
        r.x2 = r.x1;
    }

    return r;
}



int main()
{
    system("chcp 1251");
    Coefficients coeff = inputCoeff();
    Root r = extract(coeff);
    r.showRoots();

}