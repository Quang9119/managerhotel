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
	int dem=0;
	for(int i=0;i<n-1;i++)
	{
		if(A[i]==0 && A[i+1]==1)
		{
			dem++;
		}
	}
	if(dem==2)
	{
		for(int i=0;i<n;i++)
		{
			cout << A[i];
		}
		cout << endl;
	}
}
