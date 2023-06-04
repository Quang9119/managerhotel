#include <iostream>
using namespace std;
void sapxep(long A[],long n);
void chen(long A[],long &n,long x);
void xuat(long A[],long n);

int main()
{
	long A[100000],n,x;
	cin >> n;
	for(long i=0;i<n;i++)
	{
		cin >> A[i];
	}
	cin >> x;
	sapxep(A,n);
	chen(A,n,x);
	xuat(A,n);
	return 0;
}
void sapxep(long A[],long n)
{
	for(long i=0;i<n-1;i++)
	{
		for(long j=i+1;j<n;j++)
		{
			if(A[i]<A[j])
			{
				long t = A[i];
				A[i]=A[j];
				A[j]=t;
			}
		}
	}
}
void chenx(long A[],long &n,long vitri,long x)
{
	for(long i=n-1;i>=vitri;i--)
	{
		A[i+1]=A[i];
	}
	A[vitri]=x;
	n++;
}
void chen(long A[],long &n,long x)
{
	for(long i=0;i<n-1;i++)
	{
		if(x>A[i])
		{
			chenx(A,n,0,x);
			break;
		}
		else if(x<=A[i]&& x>A[i+1]) 
		{
			chenx(A,n,i+1,x);
			break;
		}
		else
		{
			A[n]=x;
			n++;
			break;
		}
	}
}
void xuat(long A[],long n)
{
	for(long i=0;i<n;i++)
	{
		cout <<  A[i] << " ";
	}
}

