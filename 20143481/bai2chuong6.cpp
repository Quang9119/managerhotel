#include <iostream>
using namespace std;

long double tinh(int n,int k);

int main()
{
	int k,n;
	cin >>k >>n;
	long double kq = tinh(n,k);
	cout << kq;
	return 0;
}
long double giaithua(int n)
{
	long double s=1;
	for(int i=1;i<=n;i++)
	{
		s*=i;
	}
	return s;
}
long double tinh(int n,int k)
{
	return giaithua(n)/(giaithua(k)*giaithua(n-k));
}
