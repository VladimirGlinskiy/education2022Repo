#include <iostream>
#include <cmath>
using namespace std;

bool Input(int& a, int& b)
{
    int x, y;

    cout << "Введите 2 числа от 1 до 100: ";
    cin >> x >> y;
    if (((x < 1) || (x > 100)) || ((y < 1) || (y > 100)))
    {
        return false;
    }

    a = x;
    b = y;

    return true;
}

int main()
{
    system("chcp 1251"); 

    int a, b;
    if (Input(a, b) == false)
    {
        cerr << "error";
        return 1;
    }
    int s = a + b;

    return 0;
}