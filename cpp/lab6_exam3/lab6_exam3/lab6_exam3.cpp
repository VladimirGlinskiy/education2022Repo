#include <iostream>
#include <nlohmann/json.hpp> 
#include <fstream> 
#include <vector>
using json = nlohmann::json;
using namespace std;

void createArrayJson(int* nums, int arrLength)
{
    json jsonObject;

    for (int i = 0; i < arrLength; i++)
    {
        cout << "Введите значение массива " << i + 1 << " из " << arrLength << endl;
        cin >> nums[i];
    }


    for (int i = 0; i < arrLength; i++) {
        jsonObject["nums"].push_back(nums[i]);
    }

    ofstream outputStream("nums.json");

    if (!outputStream)
    {
        cout << "Файл открыть невозможно\n";
    }

    outputStream << setw(4) << jsonObject << endl;
    outputStream.close();
}


vector<int> bubbleSort(vector<int> arr, int n)
{
    int min = 0;
    int buf = 0;

    for (int i = 0; i < n; i++)
    {
        min = i;

        for (int j = i + 1; j < n; j++)
        {
            min = (arr[j] < arr[min]) ? j : min;
        }
        if (i != min)
        {
            buf = arr[i];
            arr[i] = arr[min];
            arr[min] = buf;
        }
    }

    return arr;
}



void sortArrayJson()
{
    ifstream inputStream("nums.json");
    if (!inputStream)
    {
        cout << "Файл открыть невозможно\n";
    }

    json jin;
    json jout;

    inputStream >> jin;

    inputStream.close();

    vector<int> arr = jin["nums"];
    int arrLength = jin["nums"].size();


    jout["sortedNums"] = bubbleSort(arr, arrLength);


    ofstream outputStream("sortedNums.json");
    if (!outputStream)
    {
        cout << "Файл открыть невозможно\n";
    }

    outputStream << setw(4) << jout << endl;
}

int main()
{
    system("chcp 1251"); 

   const int n = 10;
   int arr[n];
   
    createArrayJson(arr, n);
    sortArrayJson();
}