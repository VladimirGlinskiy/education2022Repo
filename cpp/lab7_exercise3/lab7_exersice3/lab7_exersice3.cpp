
#include <iostream>
#include <windows.h>
using namespace std;

struct Distance
{
	int feet;
	double inches;

	void ShowDist()
	{
		cout << feet << "\'-" << inches << "\"\n";
	}
};

Distance AddDist(Distance& d1, Distance& d2)
{
	Distance d;
	d.feet = d1.feet + d2.feet;
	d.inches = d1.inches + d2.inches;
	if (d.inches >= 12.0)
	{
		d.inches -= 12.0;
		d.feet++;
	}
	return d;
}

Distance InputDist()
{
	Distance d;
	cout << "\nВведите число футов: ";
	cin >> d.feet;
	cout << "Введите число дюймов: ";
	cin >> d.inches;
	return d;
}

int main()
{
	system("chcp 1251");

	int n;
	Distance resultDistance;
	resultDistance.feet = 0; 
	resultDistance.inches = 0; 

	cout << "Введите размер массива расстояний ";
	cin >> n;
	Distance* masDist = new Distance[n];

	for (int i = 0; i < n; i++)
	{
		masDist[i] = InputDist();
	}

	for (int i = 0; i < n; i++)
	{
		(masDist[i]).ShowDist();
		resultDistance = AddDist(resultDistance, masDist[i]);
	}

	resultDistance.ShowDist();

	delete[] masDist;
}