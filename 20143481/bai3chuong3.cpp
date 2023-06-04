#include <iostream>
#include <iomanip>
using namespace std;
long double tinh(long n);

int main()
{
	int n;
	cin >>n;
	long double tong = tinh(n);
	cout << fixed << setprecision(6) <<  tong;
}
long double tinh(long n)
{
	long double tong =1;
	long long s=1;
	for(int i=2;i<=n;i++)
	{
		s=s+i;
		tong+=(double)1/s;
	}
	return tong;
}
