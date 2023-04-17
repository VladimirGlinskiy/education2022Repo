#include "Person.h"
using namespace std;

Person::Person()
{
	first_name = "none";
	last_name = "none";
	phone_num = 0;
}

Person::~Person() {};
string Person::getFirstName() { return first_name; }
string Person::getLastName() { return last_name; }
int Person::getPhoneNum() { return phone_num; }

void Person::input()
{
	cout << "Фамилия: "; cin >> last_name;
	cout << "Имя: "; cin >> first_name;
	cout << "Телефон: "; cin >> phone_num;
}

void Person::show()
{
	cout << "Фамилия: " << last_name << endl;
	cout << "Имя: " << first_name << endl;
	cout << "Телефон: " << phone_num << endl;
}
