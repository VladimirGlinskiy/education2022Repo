#include <iostream>
#include <cmath>
using namespace std;

int *max_vect(int len, int* array1, int* array2)
{
    int *max = new int[len];

    for (int i = 0; i < len; i++)
    {
        max[i] = (array1[i] > array2[i]) ? array1[i] : array2[i];
    }
    return max;
}

int main()
{
    system("chcp 1251");

    int a[] = { 1,2,3,4,5,6,7,2 };
    int b[] = { 7,6,5,4,3,2,1,3 };
    int kc = sizeof(a) / sizeof(a[0]);
    int *c; 
    c = max_vect(kc, a, b); 
    cout << "Полученный массив: " << endl;
    for (int i = 0; i < kc; i++)
        cout << c[i] << " ";
    cout << endl;
    delete []c; 
}