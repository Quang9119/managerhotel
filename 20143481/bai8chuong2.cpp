#include <iostream>
#define inf 999999999
using namespace std;
void nhap(int A[][100],int &m,int &n);
void tinhminloi(int A[][100],int m,int n,int &vitridong,int &vitricot);
void xuat(int vitridong,int vitricot);

int main()
{
	int A[100][100],m,n,vitridong,vitricot;
	nhap(A,m,n);
	tinhminloi(A,m,n,vitridong,vitricot);
	xuat(vitridong,vitricot);
	return 0;
}
void nhap(int A[][100],int &m,int &n)
{
	cin >> m >>n;
	for(int i=1;i<=m;i++)
	{
		for(int j=1;j<=n;j++)
		{
			cin >> A[i][j];
		}
	}
	for(int j=0;j<=n+1;j++)
	{
		A[0][j]=A[m+1][j]=-inf;
	}
	for(int i=0;i<=m+1;i++)
	{
		A[i][0]=A[i][n+1]=-inf;
	}
}
bool ladiemloi(int A[][100],int i,int j)
{
	int X[4]={0,0,1,-1};
	int Y[4]={-1,1,0,0};
	for(int k=0;k<4;k++)
	{
		if(A[i][j]<=A[i+X[k]][j+Y[k]])
		{
			return false;
		}
	}
	return true;
}
void tinhminloi(int A[][100],int m,int n,int &vitridong,int &vitricot)
{
	int min = inf;
	for(int i=1;i<=m;i++)
	{
		for(int j=1;j<=n;j++)
		{
			if(ladiemloi(A,i,j) && A[i][j]<min)
			{
				min = A[i][j];
				vitridong = i-1;
				vitricot = j-1;
			}
		}
	}
	if(min==inf)
	{
		vitridong= -1;
		vitricot = -1;
	}
}
void xuat(int vitridong,int vitricot)
{
	if(vitridong==-1)
	{
		cout << -1;
	}
	else
	{
		cout << vitridong << " "<< vitricot;
	}
}
/*
3 4
3 1 5 6
4 6 1 7
8 7 7 10
*/
