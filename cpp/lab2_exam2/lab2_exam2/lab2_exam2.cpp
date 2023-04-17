#include <iostream> 
#include <string> 
using namespace std;


int main()
{

	system("chcp 1251");

	int isSNILSValid = 1;
	string stringValue;
	int amount = 0;
	int remain = 0; 

	cout << "Введите СНИЛС и затем нажмите Enter: " << endl;

	cin >> stringValue;


	string snilsNumber = stringValue.substr(0, 9);
	string control = stringValue.substr(9, 2);

	for (int i = 0; i < 9; i++) {


		int digit = stoi(snilsNumber.substr(i, 1));
		int position = 9 - i;

		amount += digit * position;

		
	}

	cout << "Сумма произведений: " << amount << endl;
	remain = amount - (amount / 101 * 101);

	
	
	/*
	
	The compare() function compares two strings. 
	This function returns the following values according to the matching cases:
	
	* Returns 0 if both the strings are the same.
	* Returns < 0 (less than zero) if the value of the character of the first string is smaller as compared to the second string input.
	* Results out to be > 0 (greater than zero) when the second string is greater in comparison.
	
	*/


	if (amount < 100) {
		if (amount == stoi(control)) {
			isSNILSValid = 0; 
		};
	}

	else if (amount == 100 || amount == 101) {
		isSNILSValid = control.compare("00");
	}

	else if (amount > 101 && remain < 100) {
		if (remain == stoi(control)) {
			isSNILSValid = 0;
		}
	}

	else if (amount > 101 && remain == 100) {
		isSNILSValid = control.compare("00");
	}



	switch (isSNILSValid) {
	case 0:
		cout << "СНИЛС корректен. УРА!";
		break;

	case 1: 
		cout << "Некорректный СНИЛС";
		break;
	}

}
