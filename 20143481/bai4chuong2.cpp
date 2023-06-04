#include <iostream>
using namespace std;
void nhap(int A[][100],int &m,int &n);
void chuyenmang(int A[][100],int m,int n, int B[],int &nnew);
void xuat(int B[],int nnew);

int main()
{
	int A[100][100],m,n,B[20000],nnew;
	nhap(A,m,n);
	chuyenmang(A,m,n,B,nnew);
	xuat(B,nnew);
	return 0;
}
void nhap(int A[][100],int &m,int &n)
{
	cin >> m >>n;
	for(int i=0;i<m;i++)
	{
		for(int j=0;j<n;j++)
		{
			cin >> A[i][j];
		}
	}
}
void chuyenmang(int A[][100],int m,int n, int B[],int &nnew)
{
	nnew=0;
	for(int i=0;i<m;i++)
	{
		for(int j=0;j<n;j++)
		{
			B[nnew++]=A[i][j];
		}
	}
}
void xuat(int B[],int nnew)
{
	for(int i=0;i<nnew;i++)
	{
		cout << B[i] << " ";
	}
}
