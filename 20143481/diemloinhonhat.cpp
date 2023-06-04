#include <iostream>
using namespace std;
#define inf = 99999999
int main()
{
	int A[100][100],m,n;
	nhap(A,m,n);
	int minloi = tinh(A,m,n);
	cout <<minloi;
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
int tinh(int A[][100],int m,int n) {
	for(int )
}
