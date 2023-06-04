#include <iostream>
#include <math.h>
using namespace std;

struct DIEM
{
	int x,y;
};
void nhap(DIEM &d1);
DIEM tinhdxtung(DIEM d1);
DIEM tinhdxhoanh(DIEM d1);
DIEM tinhdxtam(DIEM d1);
float tinhkc(DIEM d1,DIEM d2);
void xuat(DIEM d1);

int main()
{
	DIEM d1,d2;
	nhap(d1);
	DIEM dxtung = tinhdxtung(d1);
	xuat(dxtung);
	DIEM dxhoanh = tinhdxhoanh(d1);
	xuat(dxhoanh);
	DIEM dxtam = tinhdxtam(d1);
	xuat(dxtam);
	nhap(d2);
	float kc = tinhkc(d1,d2);
	cout << kc;
	return 0;
}
void nhap(DIEM &d1)
{
	cin >> d1.x >> d1.y;
}
DIEM tinhdxtung(DIEM d1)
{
	DIEM kq;
	kq.x = -d1.x;
	kq.y=d1.y;
	return kq;
}
DIEM tinhdxhoanh(DIEM d1)
{
	DIEM kq;
	kq.x = d1.x;
	kq.y=-d1.y;
	return kq;
}
DIEM tinhdxtam(DIEM d1)
{
	DIEM kq;
	kq.x = -d1.x;
	kq.y= -d1.y;
	return kq;
}
float tinhkc(DIEM d1,DIEM d2)
{
	return sqrt((d1.x-d2.x)*(d1.x-d2.x) + (d1.y-d2.y)*(d1.y-d2.y));
}
void xuat(DIEM d1)
{
	cout << d1.x << " " << d1.y << endl;
}
