#include "Worker.h"

using namespace std;

Worker::Worker()
{
	team_num = "none";

}

Worker::~Worker()
{
	Worker::toFile();
}

void Worker::input()
{
	Person::input();
	int n;
	cout << "Введите номер бригады в которой состоит рабочий: " << endl; cin >> team_num;
	cout << "Добавление отработанных часов (нажмите q чтобы закончить): " << endl;
	while (cin >> n)
		hours.push_back(n);
	cin.clear();
	std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');;
}

void Worker::show()
{
	cout << "Должность: " << rank << endl;
	Person::show();
	cout << "Номер бригады: " << team_num << endl;
	cout << "Отработанные часы: ";
	for (auto x : hours)
		cout << x << " ";
	cout << endl;
}

void Worker::toFile()
{
	ofstream out("AddressBook.txt", ios::app);
	out << "Должность: " << rank << endl;
	out << "Имя: " << getFirstName() << endl;
	out << "Фамилия: " << getLastName() << endl;
	out << "Телефон: " << getPhoneNum() << endl;
	out << "Номер бригады: " << team_num << endl;
	out << "Отработанные часы: ";
	for (auto x : hours)
		out << x << " ";
	out << "\n* * *" << endl;
	out.close();
}