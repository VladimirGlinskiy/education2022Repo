#pragma once
#include "Person.h"
#include "Worker.h"
#include "Manager.h"

class AdressBook
{
public:
	void addNote();
	void toFile();
	void show();

private:
	int number_notes = 0;
	Person* notes[10];
};