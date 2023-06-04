#include <iostream>
using namespace std;
void lietke(int n);
void xuat();

int A[100],B[100]={0},n;
int main()
{
	cin >> n;
	lietke(0);
	return 0;
}
void lietke(int k)
{
	if(k==n)
	{
		xuat();
	}
	else
	{
		for(int i=0;i<n;i++)
		{
			if(B[i]==0)
			{
				A[k]=i;
				B[i]=1;
				lietke(k+1);
				B[i]=0;
			}
		}
	}
}
void xuat()
{
	for(int i=0;i<n;i++)
	{
		cout << A[i] << " ";
	}
	cout <<endl;
}
