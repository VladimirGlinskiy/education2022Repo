#include <iostream>
#include<cmath>

using namespace std;

int main()
{

    system("chcp 1251");
    cout << "Пожалуйста, задайте координаты точки \n";
    cout << "Введите значение X \n";
    double coordx;
    cin >> coordx;

    cout << "Введите значение Y \n";
    double coordy;
    cin >> coordy;

    double radius = 3; 

    if (coordy < 0 || abs(coordx) > radius || abs(coordy) > radius) {
        cout << "Снаружи";
    }
    else {
        double result = sqrt(pow(coordx, 2) + pow(coordy, 2));

        if (result == radius) {
            cout << "На границе";
        }
        else if (result < radius) {
            cout << "Внутри";
        }
        else {
            cout << "Снаружи";
        }
    }    
}





