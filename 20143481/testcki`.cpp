#include <iostream>
#include <math.h>
using namespace std;
void sinhnhiphan(int n,int B[]);
void xuat(int A[],int n,int B[],int &min);

int main()
{
	int n,B[100];
	
	cin >>n;
	for(int i=0;i<n;i++)
	{
		cin >> B[i];
	}
	sinhnhiphan(n,B);
	
	return 0;
}
void sinhnhiphan(int n,int B[])
{
	int min = 999999;
	int A[100]={0};
	int i;
	do
	{
		i=n-1;
		xuat(A,n,B,min);
		while(i>=0 && A[i]==1)
		{
			A[i]=0;
			i--;
		}
		if(i>=0)
		{
			A[i]=1;
		}
	}while(i>=0);
	cout << min;
}
void xuat(int A[],int n,int B[],int &min)
{
	int tong1=0;
	int tong2=0;
	for(int i=0;i<n;i++)
	{
		if(A[i]==1)
		{
			tong1+=B[i];
		}
		else
		{
			tong2+=B[i];
		}
	}
	if(abs(tong1-tong2)<min)
	{
		min = abs(tong1-tong2);
	}
}
