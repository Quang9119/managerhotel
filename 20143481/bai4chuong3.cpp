#include <iostream>
using namespace std;
long long tinh(long n);

int main()
{
	long n;
	cin >>n;
	long long tich = tinh(n);
	cout << tich;
}
long long tinh(long n)
{
	long long tich =1;
	long long s=1;
	for(long i=2;i<=n;i++)
	{
		s=s*i;
		tich+=s;
	}
	return tich;
}
