#pragma once
#include <string>
#include <iostream>
#include <string>
using namespace std;

class Person
{
public:
	virtual ~Person() = 0;
	Person();
	string getFirstName();
	string getLastName();
	int getPhoneNum();
	virtual void show();
	virtual void  input();
	virtual void toFile() = 0;

private:
	string first_name;
	string last_name;
	int phone_num;
};
