#include <iostream>
using namespace std;
void lietke(int n);
void xuat();
void nhap();

int A[100],B[100]={0},n;
int C[100][100];
int D[100];
int chiphimin = 999999;
int main()
{
	nhap();
	lietke(0);
	cout << chiphimin;
	return 0;
}
void nhap()
{
	cin >> n;
	for(int i=0;i<n;i++)
	{
		for(int j=0;j<n;j++)
		{
			cin >> C[i][j];
		}
	}
}
void tinhchiphi()
{
	int chiphi=0;
	for(int i=0;i<n-1;i++)
	{
		chiphi+=C[A[i]][A[i+1]];
	}
	chiphi+=C[A[n-1]][A[0]];
	if(chiphi<chiphimin)
	{
		chiphimin = chiphi;
	}
}
void lietke(int k)
{
	if(k==n)
	{
		tinhchiphi();
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
