#pragma once
#include "Dot.h"
using namespace std;

class Triangle
{
public:
	Triangle(Dot* a, Dot* b, Dot* c);
	Triangle(Dot& a, Dot& b, Dot& c);
	void countLength(Dot* a, Dot* b, Dot* c);
	double perimetr();
	double area();
	double get_abSide();
	double get_bcSide();
	double get_acSide();
private:
	Dot* a;
	Dot* b;
	Dot* c;
	double ab_side;
	double bc_side;
	double ac_side;
};