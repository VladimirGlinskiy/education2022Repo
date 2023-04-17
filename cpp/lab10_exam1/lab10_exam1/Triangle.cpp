#include "Triangle.h"
#include <math.h>
using namespace std;

Triangle::Triangle(Dot* a, Dot* b, Dot* c) : a(a), b(b), c(c)
{
	Triangle::countLength(a, b, c);
}
Triangle::Triangle(Dot& a, Dot& b, Dot& c)
{
	this->a = new Dot(a);
	this->b = new Dot(b);
	this->c = new Dot(c);

	Triangle::countLength(Triangle::a, Triangle::b, Triangle::c);
}
void Triangle::countLength(Dot* a, Dot* b, Dot* c)
{

	ab_side = a->distanceTo(*b);
	bc_side = b->distanceTo(*c);
	ac_side = a->distanceTo(*c);
}

double Triangle::get_abSide()
{
	return ab_side;
}

double Triangle::get_bcSide()
{
	return bc_side;
}

double Triangle::get_acSide()
{
	return ac_side;
}

double Triangle::perimetr()
{
	return ab_side + bc_side + ac_side;
}

double Triangle::area()
{
	double p = Triangle::perimetr() / 2;
	return sqrt(p * (p - ab_side) * (p - bc_side) * (p - ac_side));
}