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
	cout << "������� ����� ������� � ������� ������� �������: " << endl; cin >> team_num;
	cout << "���������� ������������ ����� (������� q ����� ���������): " << endl;
	while (cin >> n)
		hours.push_back(n);
	cin.clear();
	std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');;
}

void Worker::show()
{
	cout << "���������: " << rank << endl;
	Person::show();
	cout << "����� �������: " << team_num << endl;
	cout << "������������ ����: ";
	for (auto x : hours)
		cout << x << " ";
	cout << endl;
}

void Worker::toFile()
{
	ofstream out("AddressBook.txt", ios::app);
	out << "���������: " << rank << endl;
	out << "���: " << getFirstName() << endl;
	out << "�������: " << getLastName() << endl;
	out << "�������: " << getPhoneNum() << endl;
	out << "����� �������: " << team_num << endl;
	out << "������������ ����: ";
	for (auto x : hours)
		out << x << " ";
	out << "\n* * *" << endl;
	out.close();
}