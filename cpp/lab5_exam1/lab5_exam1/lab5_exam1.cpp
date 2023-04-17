#include <iostream>
#include <cmath>
using namespace std;

int sumArray(int* array, int n)
{
    int sum = 0;

    for (int i = 0; i < n; ++i)
    {
        sum += array[i];
    }
    return sum;
}

double avgArray(int* array, int n)
{
    int s = sumArray(array, n);

    return (double)s / n;
}

int sumNegativeArray(int* array, int n)
{
    int sum = 0;

    for (int i = 0; i < n; ++i)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int sumPositiveArray(int* array, int n)
{
    int sum = 0;

    for (int i = 0; i < n; ++i)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int sumOddIndexArray(int* array, int n)
{
    int sum = 0;
    for (int i = 1; i < n; i += 2) {
        sum += array[i];
    }
    return sum;
}

int sumEvenIndexArray(int* array, int n)
{
    int sum = 0;
    for (int i = 0; i < n; i += 2) {
        sum += array[i];
    }
    return sum;
}

int main()
{
    system("chcp 1251");


}