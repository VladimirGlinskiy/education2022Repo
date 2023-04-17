
#include <iostream> 
using namespace std;

int coins[] = { 1, 2, 5, 10 }; 
int main()
{
	system("chcp 1251");
	int amount;  
	cout << "Введите сумму "; cin >> amount;
	int res10 = amount / coins[3];
	cout << "Монеты номиналом 10 руб: " << res10 << " шт." << endl;

	if ((amount - res10 * coins[3]) > 0)
	{
		int res5 = ((amount - res10 * coins[3]) / coins[2]);
		cout << "Монеты номиналом 5 руб: " << res5 << " шт." << endl;

		if ((amount - res10 * coins[3] - res5 * coins[2]) > 0)
		{
			int res2 = ((amount - res10 * coins[3] - res5 * coins[2]) / coins[1]);
			cout << "Монеты номиналом 2 руб: " << res2 << " шт." << endl;

			if ((amount - res10 * coins[3] - res5 * coins[2] - res2 * coins[1]) > 0)
			{
				int res1 = ((amount - res10 * coins[3] - res5 * coins[2] - res2 * coins[1]) / coins[0]);
				cout << "Монеты номиналом 1 руб: " << res1 << " шт." << endl;
				cout << "Расчёт закончен." << endl;
			}
			else
			{
				cout << "Расчёт закончен." << endl;
			}
		}
		else
		{
			cout << "Расчёт закончен." << endl;
		}
	}
	else
	{
		cout << "Расчёт закончен." << endl;
	}
	return 0;
}