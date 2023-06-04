#include <iostream>
using namespace std;
void nhap(int &n);
int timmin(int n);
void xuat(int min);
int A[100];
int main()
{
	int n;
	nhap(n);
	int minnt = timmin(n);
	xuat(minnt);
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
bool lasnt(int x)
{
	if(x<=1)
	{
		return false;
	}
	else if(x==2)
	{
		return true;
	}
	else
	{
		for(int i=2;i<x;i++)
		{
			if(x%i==0)
			{
				return false;
			}
		}
		return true;
	}
}
int timmin(int n)
{
	if(n==1)
	{
		if(lasnt(A[0]))
		{
			return A[0];
		}
		else
		{
			return 999999;
		}
	}
	else
	{
		int x= timmin(n-1);
		if(A[n-1]< x && lasnt(A[n-1]))
		{
			return A[n-1];
		}
		else
		{
			return x;
		}
	}
}
void xuat(int min)
{
	if(min==999999)
	{
		cout << -1;
	}
	else
	{
		cout <<  min;
	}
}
