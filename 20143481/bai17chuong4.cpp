#include <iostream>
using namespace std;
void lietke(int k);
void xuat();
void nhap();

int A[10000],B[10000],P[10000],PhuongAn[10000],n;
int timemin=9999999;
int main()
{
	nhap();
	lietke(0);
	xuat();
}
void nhap()
{
	cin >> n;
	for(int i=0;i<n;i++)
	{
		cin >> A[i];
	}
	for(int i=0;i<n;i++)
	{
		cin >> B[i];
	}
}
void tinhchiphi()
{
	int ta =0;
	int tb=0;
	for(int i=0;i<n;i++)
	{
		if(P[i]==0)
		{
			ta+=A[i];
		}
		else
		{
			tb+=B[i];
		}
	}
	int tg = ta;
	if(ta<tb)
	{
		tg=tb;
	}
	if(tg<timemin)
	{
		timemin=tg;
		for(int i=0;i<n;i++)
		{
			PhuongAn[i]=P[i];
		}
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
		for(int i=0;i<=1;i++)
		{
			P[k]=i;
			lietke(k+1);
		}
	}
}
void xuat()
{
	cout << "Tong thoi gian toi uu : " << timemin << endl;
	for(int i=0;i<n;i++)
	{
		cout << PhuongAn[i] << " ";
	}
	cout << endl;
}
