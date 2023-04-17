#include "Manager.h"

Manager::Manager()
{
	department = "none";
	grade = "none";
}

Manager::~Manager()
{
	Manager::toFile();
}

void Manager::input()
{
	Person::input();
	cout << "Введите уровень менеджера: " << endl;
	cin >> grade;
	cout << "Введите название отдела: " << endl;
	cin >> department;
}

void Manager::show()
{
	Person::show();
	cout << "Должность: " << grade << endl;
	cout << "Отдел: " << department << endl;
}

void Manager::toFile()
{
	ofstream out("AddressBook.txt", ios::app);
	out << "Должность: " << rank << endl;
	out << "Имя: " << getFirstName() << endl;
	out << "Фамилия: " << getLastName() << endl;
	out << "Телефон: " << getPhoneNum() << endl;
	out << "Уровень: " << grade << endl;
	out << "Отдел: " << department << endl;
	out << "\n* * *" << endl;
	out.close();
}