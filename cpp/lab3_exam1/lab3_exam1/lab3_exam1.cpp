#include <iostream> 
#include <string> 
using namespace std;


bool verifySnilsNumber(string snils){

	int isSNILSValid = 1;
	string stringValue = snils;
	int amount = 0;
	int remain = 0;

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
		cout << "СНИЛС корректен. УРА!" << endl;
		return true; 
		break;

	case 1:
		cout << "Некорректный СНИЛС" << endl;
		return false;
		break;
	}

}

string clearString(string snils)
{

	for (int i = 0; i < snils.size(); i++) {
		if (snils[i] == '-') {
			snils.replace(i, 1, "");
		}
		if (snils[i] == ' ') {
			snils.replace(i, 1, "");
		}
	}

	return snils;
}

bool verifyChars(string snils) {
	bool isStringCorrect = true; 

	for (int i = 0; i < snils.length(); i++) {
		
		if (!isdigit(snils[i])) {
			isStringCorrect = false;
			break;
			
		}
			
	}
	return isStringCorrect;
}

int main() {
	system("chcp 1251");
	string stringValue;
	bool isNumberStringClear; 
	
	cout << "Введите СНИЛС и затем нажмите Enter: " << endl;
	getline(cin, stringValue);

	stringValue = clearString(stringValue);
	isNumberStringClear = verifyChars(stringValue); 

	if (isNumberStringClear) {
		cout << boolalpha << verifySnilsNumber(stringValue) << endl; 
	}

	else {
		cout << "Строка некорректна" << endl; 
		cout << boolalpha << isNumberStringClear << endl;
	}

}
