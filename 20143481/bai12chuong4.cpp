#include <iostream>
using namespace std;
void lietke(int n,int k);
void xuat(int A[],int k);

int main()
{
	int n,k;
	cin >> n >> k;
	lietke(n,k);
	return 0;
}
void lietke(int n,int k)
{
	int A[100];
	int i;
	for(int i=0;i<k;i++)
	{
		A[i]=i;
	}
	xuat(A,k);
	i=k-1;
	do
	{
		while(A[i]<n-k+i)
		{
			A[i]++;
			for(int j=i+1;j<k;j++)
			{
				A[j]=A[j-1]+1;
			}
			xuat(A,k);
			i=k-1;
		}
		i--;
	}while(i>=0);
}
void xuat(int A[],int k)
{
	for(int i=0;i<k;i++)
	{
		cout << A[i] << " ";
	}
	cout <<endl;
}
