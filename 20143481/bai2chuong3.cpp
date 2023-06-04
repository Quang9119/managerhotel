#include <iostream>
using namespace std;
long long tinh(long n);

int main()
{
	long n;
	cin >>n;
	long long tong = tinh(n);
	cout << tong;
}
long long tinh(long n)
{
	long long tong =1;
	long long s=1;
	for(long i=2;i<=n;i++)
	{
		s=s+i;
		tong+=s;
	}
	return tong;
}
