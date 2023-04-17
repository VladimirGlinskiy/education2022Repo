#include <iostream>
#include <windows.h>
#include <math.h>
#include <string>
#include "Triangle.h"
#include "Triangle2.h"
using namespace std;

int main()
{
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    double ax, ay, bx, by, cx, cy;
    cout << "Введите координаты вершин треугольника: ";
    cin >> ax >> ay >> bx >> by >> cx >> cy;


    Dot* a = new Dot(ax, ay);
    Dot* b = new Dot(bx, by);
    Dot* c = new Dot(cx, cy);

    Triangle* triangle = new Triangle(a, b, c);
    cout << "Сторона ab: " << triangle->get_abSide();
    cout << " Сторона ac: " << triangle->get_acSide();
    cout << " Сторона bc: " << triangle->get_bcSide() << endl;
    cout << "Периметр треугольника: " << triangle->perimetr() << endl;
    cout << "Площадь треугольника: " << triangle->area() << endl;


    Dot dot_a(ax, ay);
    Dot dot_b(bx, by);
    Dot dot_c(cx, cy);

    Triangle2 triangle2(dot_a, dot_b, dot_c);
    cout << "Сторона ab: " << triangle2.get_abSide();
    cout << " Сторона ac: " << triangle2.get_acSide();
    cout << " Сторона bc: " << triangle2.get_bcSide() << endl;
    cout << "Периметр треугольника: " << triangle2.perimetr() << endl;
    cout << "Площадь треугольника: " << triangle2.area() << endl;

}