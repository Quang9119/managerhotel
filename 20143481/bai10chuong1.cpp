#include <iostream>
#include <math.h>
using namespace std;
struct PHANSO
{
	int t,m;
};
void nhapPS(PHANSO &x);
PHANSO tinhtong(PHANSO a, PHANSO b);
void xuatPHANSO(PHANSO tong);
int tinhthuong(PHANSO a, PHANSO b, PHANSO &thuong);
void rutgon(PHANSO &x);
PHANSO tinhhieu(PHANSO a, PHANSO b);
PHANSO tinhtich(PHANSO a, PHANSO b);
void quydong(PHANSO &a,PHANSO &b);
int UCLN(int x,int y);
int tinh(PHANSO a,PHANSO b);
void nhapmang(PHANSO A[],int &n);
PHANSO tinhtongmang(PHANSO A[],int n);
PHANSO tinhmax(PHANSO A[],int n);
int tinhsosanh(PHANSO a,PHANSO b);
PHANSO tinhmin(PHANSO A[],int n);
void sapxeptangdan(PHANSO A[],int n);
void xuatmang(PHANSO A[],int n);

int main()
{
	PHANSO A[100];
	int n;
	nhapmang(A,n);
	PHANSO tong = tinhtongmang(A,n);
	xuatPHANSO(tong);
	PHANSO max = tinhmax(A,n);
	xuatPHANSO(max);
	PHANSO min = tinhmin(A,n);
	xuatPHANSO(min);
	sapxeptangdan(A,n);
	xuatmang(A,n);
	return 0;
}
void nhapmang(PHANSO A[],int &n)
{
	cin >>n;
	for(int i=0;i<n;i++)
	{
		nhapPS(A[i]);
	}
}
PHANSO tinhtongmang(PHANSO A[],int n)
{
	PHANSO t =A[0];
	for(int i=1;i<n;i++)
	{
		t = tinhtong(t,A[i]);
	}
	return t;
}
PHANSO tinhmax(PHANSO A[],int n)
{
	PHANSO max = A[0];
	for(int i=1;i<n;i++)
	{
		if(tinhsosanh(A[i],max)>0)
		{
			max = A[i];
		}
	}
	return max;
}
PHANSO tinhmin(PHANSO A[],int n)
{
	PHANSO min = A[0];
	for(int i=1;i<n;i++)
	{
		if(tinhsosanh(A[i],min)<0)
		{
			min = A[i];
		}
	}
	return min;
}
void sapxeptangdan(PHANSO A[],int n)
{
	for(int i=0;i<n-1;i++)
	{
		for(int j=i+1;j<n;j++)
		{
			if(tinhsosanh(A[i],A[j])>0)
			{
				PHANSO t = A[i];
				A[i]=A[j];
				A[j]=t;
			}
		}
	}
}
void xuatmang(PHANSO A[],int n)
{
	for(int i=0;i<n;i++)
	{
		xuatPHANSO(A[i]);
	}
}
void quydong(PHANSO &a,PHANSO &b)
{
	int bcnn = a.m*b.m/UCLN(a.m,b.m);
	a.t = a.t*bcnn/a.m;
	b.t = b.t*bcnn/b.m;
	a.m=bcnn;
	b.m = bcnn;
}
int tinhthuong(PHANSO a, PHANSO b, PHANSO &thuong)
{
	if(b.t==0)
	{
		return 0;
	}
	thuong.t = a.t * b.m;
	thuong.m = a.m *b.t;
	if(thuong.m<0)
	{
		thuong.t=-thuong.t;
		thuong.m=-thuong.m;
	}
	rutgon(thuong);
	return 1;
}
void nhapPS(PHANSO &x)
{
	cin >> x.t >> x.m;
	if(x.m<0)
	{
		x.t=-x.t;
		x.m=-x.m;
	}
}
int UCLN(int x,int y)
{
	x = abs(x);
	y = abs(y);
	if(x*y==0)
	{
		return x+y;
	}
	while(x!=y)
	{
		if(x>y)
		{
			x=x-y;
		}
		else
		{
			y=y-x;
		}
	}
	return x;
}
void rutgon(PHANSO &x)
{
	int uc = UCLN(x.t,x.m);
	x.t=x.t/uc;
	x.m=x.m/uc;
}
PHANSO tinhtich(PHANSO a, PHANSO b)
{
	PHANSO tong;
	tong.t = a.t*b.t;
	tong.m = a.m*b.m;
	rutgon(tong);
	return tong;
}
PHANSO tinhhieu(PHANSO a, PHANSO b)
{
	PHANSO tong;
	tong.t = a.t*b.m - b.t*a.m;
	tong.m = a.m*b.m;
	rutgon(tong);
	return tong;
}
PHANSO tinhtong(PHANSO a, PHANSO b)
{
	PHANSO tong;
	tong.t = a.t*b.m + b.t*a.m;
	tong.m = a.m*b.m;
	rutgon(tong);
	return tong;
}
int tinhsosanh(PHANSO a,PHANSO b)
{
	if(a.t*b.m>b.t*a.m)
	{
		return 1;
	}
	else if(a.t*b.m < b.t*a.m)
	{
		return -1;
	}
	else
	{
		return 0;
	}
}
void xuatPHANSO(PHANSO tong)
{
	cout << tong.t << " / " << tong.m << endl;
}
