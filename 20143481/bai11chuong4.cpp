#include <iostream>
using namespace std;
void lietke(int k);
void xuat();

int A[10000],n;
int main()
{
	cin >>n;
	lietke(0);
}
void lietke(int k)
{
	if(k==n)
	{
		xuat();
	}
	else
	{
		for(int i=0;i<=1;i++)
		{
			A[k]=i;
			lietke(k+1);
		}
	}
}
void xuat()
{
	for(int i=0;i<n;i++)
	{
		cout << A[i];
	}
	cout << endl;
}
