#include <iostream>
using namespace std;

class Triangle
{
public:
    Triangle(double a, double b, double c)
    {
        a_side = a;
        b_side = b;
        c_side = c;

        if (c >= a + b or a >= b + c or b >= a + c)
            throw Triangle::TriangleErr("TriangleErr");
    }
    double area() const
    {
        double halfPerimeter = (a_side + b_side + c_side) / 2;
        double areaValue = sqrt(halfPerimeter * (halfPerimeter - a_side) * (halfPerimeter - b_side) * (halfPerimeter - c_side));
        return areaValue;
    }

    class TriangleErr
    {
    public:
        string nameObj;
        TriangleErr(string triangle) : nameObj(triangle)
        {}
    };

private:
    double a_side, b_side, c_side;
};

int main()
{
    system("chcp 1251");
    double a, b, c;

    cout << "Введите стороны треугольника" << endl;
    cin >> a >> b >> c;
    try {
        Triangle triangle(a, b, c);

        cout << "Площадь треугольника: " << triangle.area() << endl;
    }
    catch (Triangle::TriangleErr& ex)
    {
        cerr << "Треугольника не существует " << ex.nameObj;
    }
}