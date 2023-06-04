#include <iostream>
#include <string.h>
using namespace std;
int tinhDoSau();
void xuat();
void lietke(int k);
void kiemtra();
int m,n;
int A[100];
int main()
{
	cin>>m>>n;
	lietke(0);
	return 0;
}
void lietke(int k)
{
	if(k==m)
	{
		kiemtra();
	}
	else
	{
		for(int i=0;i<=1;i++)
		{
			A[k]=i;
			lietke(k+1);
		}
	}
}
void kiemtra()
{
	if(tinhDoSau()==n)
	{
		xuat();
	}
}
int tinhDoSau()
{
	int i=0;
	int ngoacmo=0;
	int dosau=0;
	while (i<m)
	{
		if (A[i] ==0)
			ngoacmo++;
		else
		{
			if (ngoacmo==0)
				return -1; 
			if (ngoacmo>dosau)
				dosau = ngoacmo;
			ngoacmo--;
		}
		i++;
	}
	if(ngoacmo==0)
		return dosau;
	else
		return -1;
}
void xuat()
{
	for(int i=0;i<m;i++)
	{
		if(A[i]==0)
			cout << '(';
		else
			cout << ')';
	}
	cout << endl;
}


 

