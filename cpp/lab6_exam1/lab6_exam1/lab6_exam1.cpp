#include <iostream>
#include <cmath>
#include <nlohmann/json.hpp> 
#include <fstream> 
using json = nlohmann::json;
using namespace std;

int main()
{
    system("chcp 1251");

    const int sizeArr = 1000;
    char poem[sizeArr];

    cout << "Введите текст стихотворения. Чтобы законить, напечатайте: '!q'" << endl;
    cin.get(poem, sizeArr, '!q');

    ofstream out("poem.txt");
    if (!out)
    {
        cout << "Файл открыть невозможно" << endl;
        return 1;
    }
    out << poem;
    out.close();

    cout << "Стихотворение записалось в файл";

}