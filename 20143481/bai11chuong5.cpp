#include <iostream>
using namespace std;
void sinhnhiphan(int n);
void xuat(int A[],int n);

int main()
{
	int n;
	cin >>n;
	sinhnhiphan(n);
	return 0;
}
void sinhnhiphan(int n)
{
	int A[100]={0};
	int i;
	do
	{
		i=n-1;
		xuat(A,n);
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
}
void xuat(int A[],int n)
{
	cout << "{";
	for(int i=0;i<n;i++)
	{
		if(A[i]==1)
		{
			cout << i;
		}
	}
	cout << "}";
	cout << endl;
}
