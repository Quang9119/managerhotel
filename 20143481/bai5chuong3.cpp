#include <iostream>
#include <iomanip>
using namespace std;
long double tinh(long n);

int main()
{
	long n;
	cin >>n;
	long double tong = tinh(n);
	cout << fixed << setprecision(2) <<  tong;
}
long double tinh(long n)
{
	long double tong =1;
	long double s=1;
	for(long i=1;i<=n;i++)
	{
		s=s*i;
		tong+=(long double)1/s;
	}
	return tong;
}
