#pragma once
#include "Person.h"
#include <fstream>
class Manager : public Person
{
public:
	Manager();
	~Manager();
	void show();
	void input();
	void toFile();

private:
	string rank = "�����������";
	string department;
	string grade;
};