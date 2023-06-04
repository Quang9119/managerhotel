#include <iostream>
using namespace std;
void nhap(int A[][100],int &m,int &n);
void timpt(int A[][100],int m,int n);
void xuat(int x);

int main()
{
	int A[100][100],m,n;
	cin >>m>>n;
	nhap(A,m,n);
	timpt(A,m,n);
	return 0;
}
void nhap(int A[][100],int &m,int &n)
{
	for(int i=0;i<m;i++)
	{
		for(int j=0;j<n;j++)
		{
			cin >>A[i][j];
		}
	}
}
bool maxdong(int x,int A[][100],int dong,int n)
{
	for(int j=0;j<n;j++)
	{
		if(A[dong][j]>x)
		{
			return false;
		}
	}
	return true;
}
bool mincot(int x,int A[][100],int cot,int m)
{
	for(int i=0;i<m;i++)
	{
		if(A[i][cot]<x)
		{
			return false;
		}
	}
	return true;
}
void timpt(int A[][100],int m,int n)
{
	for(int i=0;i<m;i++)
	{
		for(int j=0;j<n;j++)
		{
			if(maxdong(A[i][j],A,i,n) && mincot(A[i][j],A,j,m))
			{
				xuat(A[i][j]);
			}
		}
	}
}
void xuat(int x)
{
	cout <<x;
}
