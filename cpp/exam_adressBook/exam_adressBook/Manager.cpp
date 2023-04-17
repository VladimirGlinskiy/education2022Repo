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
	cout << "������� ������� ���������: " << endl;
	cin >> grade;
	cout << "������� �������� ������: " << endl;
	cin >> department;
}

void Manager::show()
{
	Person::show();
	cout << "���������: " << grade << endl;
	cout << "�����: " << department << endl;
}

void Manager::toFile()
{
	ofstream out("AddressBook.txt", ios::app);
	out << "���������: " << rank << endl;
	out << "���: " << getFirstName() << endl;
	out << "�������: " << getLastName() << endl;
	out << "�������: " << getPhoneNum() << endl;
	out << "�������: " << grade << endl;
	out << "�����: " << department << endl;
	out << "\n* * *" << endl;
	out.close();
}