#include <iostream>
using namespace std;
long long tinh(int n,int k);

int main()
{
	int n,k;
	cin >>n>>k;
	long long kq = tinh(n,k);
	cout <<kq;
	return 0;
}
long long tinh(int n,int k)
{
	if(k==1)
	{
		return n;
	}
	else if(k==n)
	{
		return 1;
	}
	else
	{
		return tinh(n-1,k-1) + tinh(n-1,k);
	}
}
