#include <iostream>

using namespace std;

int main()
{
    system("chcp 1251");
    int coordinate[5][2];
    int addition = 0;
    int subtraction = 0;
    double squareValue = 0;

    int index = sizeof (coordinate) / sizeof(coordinate[0]);

    cout << "Длина массива " << index << endl; 

    for (int i = 0; i < index; i++) {
        cout << "Введите значение X для точки " << i << endl; 
        cin >> coordinate[i][0];
        cout << "Введите значение Y для точки " << i << endl;
        cin >> coordinate[i][1];
    }

    for (int i = 0; i <= index-1; i++) {
    
        if (i == index-1) {

            addition += coordinate[i][0] * coordinate[0][1];
            subtraction += coordinate[i][1] * coordinate[0][0];
        }

        else
        {
            addition += coordinate[i][0] * coordinate[i + 1][1];
            subtraction += coordinate[i][1] * coordinate[i + 1][0];
        }
    }

    squareValue = 0.5 * abs(addition - subtraction);
    cout << "Размер площади " << squareValue << endl;
}
