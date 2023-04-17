#include "AdressBook.h"

void AdressBook::addNote()
{
	int choice_person;
	string choice;
	do {
		cout << "Записать рабочего или менеджера? Нажмите 1 для рабочего, 2 для менеджера. " << endl;
		cin >> choice_person;

		switch (choice_person)
		{

		case 1: 
			notes[number_notes] = new Worker;
			notes[number_notes]->input();

			break;

		case 2:

			notes[number_notes] = new Manager();
			notes[number_notes]->input();

			break;


		default:
			break;
		}

		number_notes++;
		cout << "Добавить ещё людей? 'y'/'n'" << endl;
		cin >> choice;
	} while (choice == "y");
}

void AdressBook::show()
{
	for (int j = 0; j < number_notes; j++)
	{

		notes[j]->show();
	}
}

void AdressBook::toFile()
{
	for (int j = 0; j < number_notes; j++)
	{
		notes[j]->toFile();
	}
}