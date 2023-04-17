#include <iostream>
#include <cmath>
using namespace std;

int Sum(int n)
{
    if (n == 1) return 5;
    else return(n * 5 + Sum(n - 1));
}

int main()
{
    system("chcp 1251");
    int number;
    cout << "Введите число: " << endl; 
    cin >> number;
    cout << "Результат вычисления: "  << Sum(number) << endl;
}