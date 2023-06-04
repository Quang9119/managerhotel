#include <iostream>
using namespace std;
void nhap(int A[],int &mA,int &nA);
void chuyen(int A[],int mA,int nA,int B[][100]);
void xuat(int B[][100],int m,int n);

int main()
{
	int A[10000],mA,nA,B[100][100];
	nhap(A,mA,nA);
	chuyen(A,mA,nA,B);
	xuat(B,mA,nA);
	return 0;
}
void nhap(int A[],int &mA,int &nA)
{
	cin >> mA >> nA;
	for(int i=0;i<mA*nA;i++)
	{
		cin >> A[i];
	}
}
void chuyen(int A[],int mA,int nA,int B[][100])
{
	int k=0;
	for(int i=0;i<mA;i++)
	{
		for(int j=0;j<nA;j++)
		{
			B[i][j]=A[k++];
		}
	}
}
void xuat(int B[][100],int m,int n)
{
	for(int i=0;i<m;i++)
	{
		for(int j=0;j<n;j++)
		{
			cout << B[i][j] << " ";
		}
		cout << endl;
	}
}
