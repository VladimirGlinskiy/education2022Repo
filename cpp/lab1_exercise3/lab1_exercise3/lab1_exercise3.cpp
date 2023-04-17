#include <iostream>
#include<cmath>

using namespace std;
int main()
{
    system("chcp 1251");
    cout << "Пожалуйста, введите значение периметра \n";
    double perimeter; 
    cin >> perimeter; 

    double halfOfaPerimeter = perimeter / 2;
    double sideOfAtriangle = perimeter / 3; 

    double result = sqrt(halfOfaPerimeter * 3 * (halfOfaPerimeter - sideOfAtriangle));
    cout << "result " << result; 
}
