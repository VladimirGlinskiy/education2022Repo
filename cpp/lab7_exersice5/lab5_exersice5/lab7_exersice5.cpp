
#include <iostream>
#include <string>
#include <tuple>
#include <vector>

using namespace std;
using Tuple = tuple<string, int, double>;
using TupleTwo = tuple<string, double>;


void printTupleOfThree(Tuple t)
{
	cout << "("
		<< get<0>(t) << ", "
		<< get<1>(t) << ", "
		<< get<2>(t) << ")" << endl;
}

void printTupleOfTwo(TupleTwo t)
{
	cout << "("
		<< get<0>(t) << ", "
		<< get<1>(t) << ")" << endl;
}

Tuple funtup(string s, int a, double d)
{
	s.append("!");
	return make_tuple(s, a, d * 10);
}

Tuple secondFunTuple(Tuple t) 
{
	return make_tuple(get<0>(t).append("++"), pow(get<1>(t), 2), get<2>(t) * 100);
}


int main()
{
	system("chcp 1251");
	vector<string> v1{ "one", "two", "three", "four", "five", "six" };
	vector<int> v2 = { 1, 2, 3, 4, 5, 6 };
	vector<double> v3 = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };

	auto t0 = make_tuple(v1[0], v2[0], v3[0]);
	auto t1 = funtup(v1[1], v2[1], v3[1]);
	auto t2 = make_tuple(v1[5], v2[5], v3[5]);

	printTupleOfThree(t0);
	printTupleOfThree(t1);
	printTupleOfThree(secondFunTuple(t2));  

	return 0;
}