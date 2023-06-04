#include <iostream>
using namespace std;
void nphantudau(int A[],int n);
void xuat(int A[],int n);

int main()
{
	int n,A[100];
	cin >>n;
	nphantudau(A,n);
	xuat(A,n);
	return 0;
}
void nphantudau(int A[],int n)
{
	A[0]=0;
	A[1]=1;
	for(int i=2;i<=n;i++)
	{
		A[i]=A[i-1]+A[i-2];
	}
}
void xuat(int A[],int n)
{
	for(int i=0;i<=n;i++)
	{
		cout << A[i] << " ";
	}
}

