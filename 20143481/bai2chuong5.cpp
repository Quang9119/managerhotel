#include <iostream>
#include <math.h>
using namespace std;
int tongcacsoAms(int A[],int n);

int main()
{
	int A[100],n;
	cin >>n;
	for(int i=0;i<n;i++)
	{
		cin >> A[i];
	}
	int tong = tongcacsoAms(A,n);
	cout << tong;
	return 0;
}
bool lasoAms(int x)
{
	int n=x;
	int temp = x;
	int tong=0;
	int chuso=0;
	while(x>0)
	{
		x/=10;
		chuso++;
	}
	while(temp>0)
	{
		int a = temp%10;
		tong+=pow(a,chuso);
		temp/=10;
	}
	if(tong==n)
	{
		return true;
	}
	return false;
}

int tongcacsoAms(int A[],int n)
{
	int tong=0;
	for(int i=0;i<n;i++)
	{
		if(lasoAms(A[i]))
		{
			tong+=A[i];
		}
	}
	return tong;
}
