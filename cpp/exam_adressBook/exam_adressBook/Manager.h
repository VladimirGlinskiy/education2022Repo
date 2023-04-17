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
	string rank = "”правл€ющий";
	string department;
	string grade;
};