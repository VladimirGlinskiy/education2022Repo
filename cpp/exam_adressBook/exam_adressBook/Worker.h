#pragma once
#include <vector>
#include <fstream>
#include "Person.h"

using namespace std;

class Worker : public Person
{
public:
	Worker();
	~Worker();
	void input();
	void show();
	void toFile();

private:
	string rank = "Рабочий";
	vector<int> hours;
	string team_num;
};
