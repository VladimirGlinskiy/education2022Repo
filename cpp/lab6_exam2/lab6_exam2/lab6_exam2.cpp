#include <iostream>
#include <cmath>
#include <nlohmann/json.hpp> 
#include <fstream> 
using json = nlohmann::json;
using namespace std;

void recArrToFile(int* arr, int arrLength)
{
    ofstream out("Array.txt", ios::app);

    if (!out)
    {
        cout << "Файл открыть невозможно\n";
        return;
    }

    for (int i = 0; i < arrLength; i++)
    {
        out << arr[i] << " ";
    }

    out << endl;
    out.close();
}

int sortArr(int* arr, int arrLength)
{
    int min = 0;
    int buf = 0;

    for (int i = 0; i < arrLength; i++)
    {
        min = i;

        for (int j = i + 1; j < arrLength; j++)
            min = (arr[j] < arr[min]) ? j : min;

        if (i != min)
        {
            buf = arr[i];
            arr[i] = arr[min];
            arr[min] = buf;
        }
    }

    return *arr;
}

int initArray(int* nums, int n)
{

    for (int i = 0; i < n; i++)
    {
        cout << "Введите значение массива " << i+1 << " из " << n << endl;
        cin >> nums[i]; 
    }

    return *nums;
}

int main()
{
    system("chcp 1251");

    const int arrLength = 10;
    int arr[arrLength];

    initArray(arr, arrLength);

    recArrToFile(arr, arrLength);

    sortArr(arr, arrLength);

    recArrToFile(arr, arrLength);

}


