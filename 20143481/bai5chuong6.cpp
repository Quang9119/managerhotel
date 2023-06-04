#include <iostream>
using namespace std;
void tich2matran(int A[][100],int n,int B[][100],int C[][100]);
void xuat(int C[][100],int n);

int main()
{
	int n,A[100][100],B[100][100],C[100][100];
	cin >>n;
	for(int i=0;i<n;i++)
	{
		for(int j=0;j<n;j++)
		{
			cin >> A[i][j];	
		}
	}
	for(int i=0;i<n;i++)
	{
		for(int j=0;j<n;j++)
		{
			cin >> B[i][j];	
		}
	}
	tich2matran(A,n,B,C);
	xuat(C,n);
	return 0;
}
void tich2matran(int A[][100],int n,int B[][100],int C[][100])
{
	for(int i=0;i<n;i++)
	{
		for(int j=0;j<n;j++)
		{
			int kq =0;
			for(int k=0;k<n;k++)
			{
				kq = kq +(A[i][k]*B[k][j]);
			}
			C[i][j]=kq;
		}
	}
}
void xuat(int C[][100],int n)
{
	for(int i=0;i<n;i++)
	{
		for(int j=0;j<n;j++)
		{
			cout << C[i][j] << " ";	
		}
		cout << endl;
	}
}
