#include <math.h>
#include <iostream>
#include <string>
#include <vector>
#include <algorithm> 

using namespace std;

class Point
{
public:

	Point(double x, double y) : coordX(x), coordY(y) {}

	double distToCentr() const {
		return sqrt(pow((coordX - 0), 2) + pow((coordY - 0), 2));;
	}

	friend ostream& operator<< (ostream&, const Point&);
	friend bool operator<(const Point&, const Point&);

private:
	double coordX;
	double coordY;
};

ostream& operator<< (ostream& out, const Point& p)
{
	out << "(" << p.coordX << ", " << p.coordY << ")" << endl;
	return out;
}
bool operator<(const Point& p1, const Point& p2) {
	if (p1.distToCentr() < p2.distToCentr()) return true;
	return false;
}

int main()
{
	std::vector<Point> v;
	v.push_back(Point(1, 2));
	v.push_back(Point(10, 12));
	v.push_back(Point(21, 7));
	v.push_back(Point(4, 8));
	std::sort(v.begin(), v.end()); 
	
	for (auto& point : v)
		std::cout << point << '\n';
	return 0;
}