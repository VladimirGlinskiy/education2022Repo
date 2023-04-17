
#include <iostream> 
using namespace std;

int main()
{
	system("chcp 1251");
	const int arrayLength = 10;   
	double average;           
	int sum = 0;          
	int sNegative = 0;  
	int sPositive = 0;  
	int sOdd = 0;       
	int sEven = 0;      

	int mas[arrayLength];

	for (int i = 0; i < arrayLength; i++)
	{
		cout << "Введите значение массива " << i+1 << " из " << arrayLength << endl;
		cin >> mas[i];
	}

	for (int i = 0; i < arrayLength; i++)
	{
		sum += mas[i];
	}
	cout << "Сумма всех элементов массива: " << sum << endl;

	average = (double)sum / arrayLength;
	cout << "Среднее значение элементов массива: " << average << endl;

	for (int i = 0; i < arrayLength; i++)
	{
		if (mas[i] < 0)
		{
			sNegative += mas[i];
		}
		else
		{
			sPositive += mas[i];
		}
	}
	cout << "Сумма всех отрицательных элементов массива: " << sNegative << endl;
	cout << "Сумма всех положительных элементов массива: " << sPositive << endl;

	for (int i = 1; i < arrayLength; i = i + 2)
	{
		sOdd += mas[i];
	}
	cout << "Сумма элементов с нечетными индексами: " << sOdd << endl;

	for (int i = 0; i < arrayLength; i = i + 2)
	{
		sEven += mas[i];
	}
	cout << "Сумма элементов с четными индексами: " << sEven << endl;
}