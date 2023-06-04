#include <iostream>
using namespace std;
void xoatrung(int A[],int &n);
void xuat(int A[],int n);

int main()
{
	int n,A[100000];
	cin >>n;
	for(int i=0;i<n;i++)
	{
		cin >> A[i];
	}
	xoatrung(A,n);
	xuat(A,n);
	return 0;
}
void xoa1phantu(int  vitri,int A[],int &n)
{
	for(int i=vitri;i<n-1;i++)
	{
		A[i]=A[i+1];
	}
	A[n]='\0';
	n--;
}
void xoatrung(int A[],int &n)
{
	for(int i=0;i<n;i++)
	{
		for(int j=i+1;j<n;j++)
		{
			if(A[j]==A[i])
			{
				xoa1phantu(j,A,n);
				j--;
			}
		}
	}
}
void xuat(int A[],int n)
{
	for(int i=0;i<n;i++)
	{
		cout << A[i] << " ";
	}
}
