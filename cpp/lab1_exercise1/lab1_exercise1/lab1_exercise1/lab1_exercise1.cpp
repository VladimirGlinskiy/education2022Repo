#include <iostream>
#include <windows.h>
#include <string>
using namespace std;

int main()
{

    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);
    string name;
    cout << "Как тебя зовут?\n";
    getline(cin, name);
    cout << "Hello, " << name << "!\n";
}
