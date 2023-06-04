#include <iostream>
using namespace std;
void dituan(int x,int y);
void xuat();

int A[100][100]={0},n=6,dem=0;
int X[8]={-2,-2,-1,1,2,2,1,-1};
int Y[8]={-1,1,2,2,1,-1,-2,-2};
int main()
{
	dituan(2,3);
	cout << "Khong co phuong an" << endl;
}
void dituan(int x,int y)
{
	dem++;
	A[x][y]=dem;
	if(dem==n*n)
	{
		xuat();
		exit(0);
	}
	for(int i=0;i<8;i++)
	{
		int xx = x+X[i];
		int yy= y+Y[i];
		if(xx>=0 && xx<n && yy>=0 && yy<n && A[xx][yy]==0)
		{
			dituan(xx,yy);
		}
	}
	dem--;
	A[x][y]=0;
}
void xuat()
{
	for(int i=0;i<n;i++)
	{
		for(int j=0;j<n;j++)
		{
			cout << A[i][j] << " ";
		}
		cout << endl;
	}
}
