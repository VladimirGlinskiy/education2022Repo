#include <iostream> 
#include <ctime>
#include <vector>

using namespace std;

int main()
{
	system("chcp 1251");
	vector<int> v1;
	vector<int> v2;
	int a, b, c;
	int k = 0;

	const int n = 10;
	int mas[n];

	for (int i = 0; i < n;i++)
	{
		a = rand() % 10 + 1;
		b = rand() % 10 + 1;
		cout << a << " * " << b << " = ";
		cin >> c;
		mas[i] = c;
		if (a * b != c)
		{
			v2.push_back(c);
			k++;
			cout << "Error! " << endl;
			cout << a << " * " << b << " = " << a * b << endl;
		}
		else {
			v1.push_back(c);
			cout << "Correct! " << endl;
		}
	}
	cout << "Введенные ответы:" << endl;

	for (int i = 0; i < n; i++)
	{
		cout << mas[i] << endl;
	}

	cout << "Правильные ответы: " << endl;
	for (int i = 0; i < v1.size(); i++)
	{
		cout << v1[i] << endl;
	}

	cout << "Неправильные ответы: " << endl; 
	for (int i = 0; i < v2.size(); i++)
	{
		cout << v2[i] << endl;
	}

	cout << "Count error: " << k << endl;
	return 0;
}