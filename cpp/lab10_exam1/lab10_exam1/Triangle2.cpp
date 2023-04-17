#include "Triangle2.h"
#include <math.h>
using namespace std;

Triangle2::Triangle2(Dot a, Dot b, Dot c) : a(a), b(b), c(c)
{
	Triangle2::countLength(a, b, c);
}

void Triangle2::countLength(Dot a, Dot b, Dot c)
{

	ab_side = a.distanceTo(b);
	bc_side = b.distanceTo(c);
	ac_side = a.distanceTo(c);
}

double Triangle2::get_abSide()
{
	return ab_side;
}

double Triangle2::get_bcSide()
{
	return bc_side;
}

double Triangle2::get_acSide()
{
	return ac_side;
}

double Triangle2::perimetr()
{
	return ab_side + bc_side + ac_side;
}

double Triangle2::area()
{
	double p = Triangle2::perimetr() / 2;
	return sqrt(p * (p - ab_side) * (p - bc_side) * (p - ac_side));
}