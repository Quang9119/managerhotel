#include <iostream>
#include <math.h>
using namespace std;
struct PHANSO
{
	int t,m;
};
struct HONSO
{
	int nguyen;
	PHANSO ps;
};
void nhapHS(HONSO &x);
HONSO tinhtongHS(HONSO a,HONSO b);
void xuatHS(HONSO x);
PHANSO tinhtongPS(PHANSO a, PHANSO b);
void rutgon(PHANSO &x);
HONSO tinhtichHS(HONSO a,HONSO b);

int main()
{
	HONSO a,b;
	nhapHS(a);
	nhapHS(b);
	HONSO tong = tinhtongHS(a,b);
	xuatHS(tong);
	HONSO tich = tinhtichHS(a,b);
	xuatHS(tich);
	return 0;
}
HONSO chuyenPSsangHS(PHANSO a)
{
	HONSO kq;
	kq.nguyen = a.t/a.m;
	kq.ps.t = a.t % a.m;
	kq.ps.m = a.m;
	return kq;
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
void nhapHS(HONSO &x)
{
	cin >> x.nguyen;
	nhapPS(x.ps);
}
PHANSO chuyenHSsangPS(HONSO a)
{
	PHANSO kq;
	kq.m=a.ps.m;
	kq.t = a.ps.t+a.nguyen*a.ps.m;
	rutgon(kq);
	return kq;
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
PHANSO tinhtichPS(PHANSO a, PHANSO b)
{
	PHANSO tong;
	tong.t = a.t*b.t;
	tong.m = a.m*b.m;
	rutgon(tong);
	return tong;
}
HONSO tinhtongHS(HONSO a,HONSO b)
{
	PHANSO aa = chuyenHSsangPS(a);
	PHANSO bb = chuyenHSsangPS(b);
	PHANSO tt = tinhtongPS(aa,bb);
	HONSO t = chuyenPSsangHS(tt);
	return t;
}
HONSO tinhtichHS(HONSO a,HONSO b)
{
	PHANSO aa = chuyenHSsangPS(a);
	PHANSO bb = chuyenHSsangPS(b);
	PHANSO tt = tinhtichPS(aa,bb);
	HONSO t = chuyenPSsangHS(tt);
	return t;
}
PHANSO tinhtongPS(PHANSO a, PHANSO b)
{
	PHANSO tong;
	tong.t = a.t*b.m + b.t*a.m;
	tong.m = a.m*b.m;
	rutgon(tong);
	return tong;
}
void xuatPS(PHANSO tong)
{
	cout << tong.t << " / " << tong.m << endl;
}
void xuatHS(HONSO x)
{
	cout << x.nguyen << " ";
	xuatPS(x.ps);
}

