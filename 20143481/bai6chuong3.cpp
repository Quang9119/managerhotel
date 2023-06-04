#include <iostream>
#include <iomanip>
using namespace std;
long double tinh(long x,long n);

int main()
{
	long n,x;
	cin >>n >>x;
	long double tong = tinh(x,n);
	cout << fixed << setprecision(2) <<  tong;
}
long double tinh(long x,long n)
{
	long double tong =1;
	long double s=1;
	for(long i=1;i<=n;i++)
	{
		s=(long double)(s*x)/i;
		tong+=s;
	}
	return tong;
}
