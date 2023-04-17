#include <iostream> 
using namespace std;
	
int main()
{
	system("chcp 1251");
	int shotNumber;   
	int receivedPoints = 0;
	int maxAvailablePoints;
	int averageNumberOfPoints;
	double x, y,  radius;        

	cout << "Введите количество выстрелов "; cin >> shotNumber;
	maxAvailablePoints = shotNumber * 10;
	averageNumberOfPoints = shotNumber * 5;

	for(int i = 1; i < shotNumber+1; i++)
	{
		cout << "Выстрел " << i << endl;
		cout << "Введите координату x: " << endl;
		cin >> x;
		cout << "Введите координату y:" << endl; 
		cin >> y;
		radius = sqrt(pow(x, 2) + pow(y, 2));

		if (radius <= 3 && radius > 2)
		{
			receivedPoints += 1;
			
		}
		else if (radius <= 2 && radius > 1)
		{
			receivedPoints += 5;
			
		}
		else if (radius <= 1)
		{
			receivedPoints += 10;
			
		}
		else
		{
			shotNumber--;
		}
		cout << "Выстрел " << i << endl;
		cout << "Промежуточный результат стрельбы: " << receivedPoints << endl; 
	}

	cout << "Итоговое количество очков: " << receivedPoints << endl;

	if (receivedPoints < averageNumberOfPoints)
	{
		cout << "Уровень: новичок." << endl;
	}
	else if (receivedPoints >= averageNumberOfPoints && receivedPoints < maxAvailablePoints)
	{
		cout << "Уровень: просто стрелок." << endl;
	}
	else if (receivedPoints == maxAvailablePoints)
	{
		cout << "Уровень: снайпер." << endl;
	}
	return 0;
}