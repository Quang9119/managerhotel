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
int tinhsosanh(PHANSO a,PHANSO b);

int main()
{
	PHANSO a,b,thuong;
	nhapPS(a);
	nhapPS(b);
	quydong(a,b);
	xuatPHANSO(a);
	xuatPHANSO(b);
	PHANSO tong = tinhtong(a,b);
	xuatPHANSO(tong);
	PHANSO hieu = tinhhieu(a,b);
	xuatPHANSO(hieu);
	PHANSO tich = tinhtich(a,b);
	xuatPHANSO(tich);
	int kt = tinhthuong(a,b,thuong);
	if(kt ==0)
	{
		cout << "Khong the thuc hien phep chia." << endl;
	}
	else
	{
		xuatPHANSO(thuong);
	}
	int sosanh = tinhsosanh(a,b);
	cout << sosanh << endl;
	return 0;
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
	if(a.t>b.t)
	{
		return 1;
	}
	else if(a.t < b.t)
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
