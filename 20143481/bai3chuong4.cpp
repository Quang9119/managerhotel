#include <iostream>
using namespace std;
long long tinhgiaithua(int n);

int main()
{
	int n;
	cin >>n;
	long long kq = tinhgiaithua(n);
	cout <<kq;
	return 0;
}
long long tinhgiaithua(int n)
{
	int tich =n;
	if(n==1||n==0)
	{
		return 1;
	}
	else
	{
		return tich*tinhgiaithua(n-1);
	}
}
