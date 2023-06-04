#include <iostream>
using namespace std;
void nhap(long long A[],long long &n);
long long tinh(long long A[],int n,long long B[]);

int main()
{
	long long A[1000],n,B[1000]={0};
	nhap(A,n);
	long long giatri = tinh(A,n,B);
	cout <<giatri;
	return 0;
}
void nhap(long long A[],long long &n)
{
	cin >>n;
	for(int i=0;i<n;i++)
	{
		cin >> A[i];
	}
}
long long tinh(long long A[],int n,long long B[])
{
	for(int i=0;i<n;i++)
	{
		for(int j=i;j<n;j++)
		{
			if(A[j]==A[i])
			{
				B[i]++;
			}
		}
	}
	long long maxB = B[0];
	int vitrimax=0;
	for(int i=1;i<n;i++)
	{
		if(B[i]>maxB)
		{
			maxB = B[i];
			vitrimax = i;
		}
	}
	int minA = A[vitrimax];
	for(int i=0;i<n;i++)
	{
		if(maxB==B[i] && A[i]<minA)
		{
			minA=A[i];
		}
	}
	return minA;
}
