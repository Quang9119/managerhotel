#include <iostream>
using namespace std;
void xoanoc(int A[][100],int n);
void xuat(int A[][100],int n);

int main()
{
	int n,A[100][100];
	cin >> n;
	xoanoc(A,n);
	xuat(A,n);
	return 0;
}
void xoanoc(int A[][100],int n)
{
	int d=0;
	int giatri=1;
	int hang=n-1;
	int cot=n-1;
	while(d<=(n/2))
	{
			for(int i=d;i<=cot;i++)
		{
			A[d][i]=giatri++;
		}
		for(int i=d+1;i<=hang;i++)
		{
			A[i][cot]=giatri++;
		}
		for(int i=cot-1;i>=d;i--)
		{
			A[hang][i]=giatri++;
		}
		for(int i=hang-1;i>=d+1;i--)
		{
			A[i][d]=giatri++;
		}
		d++;
		hang--;
		cot--;
	}
	
}
void xuat(int A[][100],int n)
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
