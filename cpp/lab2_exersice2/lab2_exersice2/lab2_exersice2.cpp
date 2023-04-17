#include <iostream>
using namespace std;

int main()
{
	system("chcp 1251");
	char op;
	cout << "Сделай свой выбор, собери авто свой мечты:\n";
	cin >> op;

	switch (op)
	{
	case 'S':
		cout << "Радио играть должно\n";
		cout << "Колеса круглые\n";
		break;
	case 'V':
		cout << "Кондиционер хочу\n";
		break;
	default:
		cout << "Мощный двигатель\n";
	}
}