#include <iostream> 
using namespace std;

int main()
{
	system("chcp 1251");
	
	const int n = 10;   
	int mas[n];
	
	double average;           
	int sum = 0;          
	int sNegative = 0;  
	int sPositive = 0;  
	int sOdd = 0;       
	int sEven = 0;      

	

	for (int i = 0; i < n; i++)
	{
		cout << "Введите число массива " << i + 1 << " из " << n <<":" << endl;
		cin >> mas[i];
	}

	for (int i = 0; i < n; i++)
	{
		sum += mas[i];
	}
	cout << "Сумма всех элементов массива: " << sum << endl;

	average = (double)sum / n;
	cout << "Среднее значение элементов массива: " << average << endl;

	for (int i = 0; i < n; i++)
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

	for (int i = 1; i < n; i = i + 2)
	{
		sOdd += mas[i];
	}
	cout << "Сумма элементов с нечетными индексами: " << sOdd << endl;

	for (int i = 0; i < n; i = i + 2)
	{
		sEven += mas[i];
	}
	cout << "Сумма элементов с четными индексами: " << sEven << endl;
}