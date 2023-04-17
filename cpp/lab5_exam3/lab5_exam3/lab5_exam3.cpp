#include <iostream>
#include <cmath>
using namespace std;


int transpositionSearch(int *array, int size, int element)
{
    int answerIndex;

    for (int i = 0; i < size; i++)
    {
        if (array[i] == element)
        {
            answerIndex = i;

            if (answerIndex == 0)
            {
                break;
            }

            else
            {
                swap(array[i], array[i - 1]);
            }
        }
    }
    return answerIndex;
}

int main()
{
    system("chcp 1251"); 

    int arr[] = { 2, 88, 100, 133, 285, 33};

    int arrayLength = sizeof(arr) / sizeof(arr[0]); 


    for (int i = 0; i < arrayLength; i++)
    {
        cout << "Индекс числа 33: " << transpositionSearch(arr, arrayLength, 33) << endl;
    }
}