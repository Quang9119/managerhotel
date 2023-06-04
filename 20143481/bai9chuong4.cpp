#include <iostream>
using namespace std;
void nhap(int &n);
int ucln(int n);
int A[100];
int main()
{
	int n;
	nhap(n);
	int UCLN = ucln(n);
	cout << UCLN;
	return 0;
}
void nhap(int &n)
{
	cin >> n;
	for(int i=0;i<n;i++)
	{
		cin >> A[i];
	}
}
int ucln2so(int a,int b)
{
	while(a!=b)
	{
		if(a>b)
		{
			a-=b;
		}
		else
		{
			b-=a;
		}
	}
	return a;
}
int ucln(int n)
{
	if(n==2)
	{
		return ucln2so(A[0],A[1]);
	}
	else
	{
		return ucln2so(A[n-1],ucln(n-1));
	}
}
