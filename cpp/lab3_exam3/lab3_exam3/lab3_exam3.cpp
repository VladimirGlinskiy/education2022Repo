#include <iostream>
#include <cmath>
using namespace std;

double countTriangleArea(double length)
{
    double areaValue;

    areaValue = (sqrt(3) / 4) * pow(length, 2);
    return areaValue;
}


double countTriagleArea(double a, double b, double c)
{

    double halfPerimeter, areaValue;

    halfPerimeter = (a + b + c) / 2;
    areaValue = sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

    return areaValue;
}

int main()
{
    system("chcp 1251");

    char triangleType;
    cout << "Выберите тип треугольника: 1 - Равносторонний треугольник, 2 - Разносторонний треугольник" << endl;
    cin >> triangleType;

    switch (triangleType)
    {
    case '1':
        double length;
        cout << "Введите длину стороны равностороннего треугольника и нажмите Enter:" << endl;
        cin >> length;
        cout << "Площадь треугольника равна: " << countTriangleArea(length);
        break;
    case '2':
        double n1, n2, n3;
        cout << "Введите через пробел размеры трех сторон разностороннего треугольника и затем нажмите Enter: " << endl;
        cin >> n1 >> n2 >> n3;
        cout << "Площадь треугольника равна: " << countTriagleArea(n1, n2, n3) << endl;
        break;
    default:
        cout << "Вы ввели некорректное значение!" << endl;
    }
    return 0;

}