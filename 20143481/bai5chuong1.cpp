#include <iostream>
using namespace std;

struct SOPHUC
{
	int a,b;
};
void nhap(SOPHUC &s1);
SOPHUC tinhtong(SOPHUC s1,SOPHUC s2);
SOPHUC tinhhieu(SOPHUC s1,SOPHUC s2);
SOPHUC tinhtich(SOPHUC s1,SOPHUC s2);
void xuat(SOPHUC s1);

int main()
{
	SOPHUC s1,s2;
	nhap(s1);
	nhap(s2);
	SOPHUC tong = tinhtong(s1,s2);
	xuat(tong);
	SOPHUC hieu = tinhhieu(s1,s2);
	xuat(hieu);
	SOPHUC tich = tinhtich(s1,s2);
	xuat(tich);
	return 0;	
}
void nhap(SOPHUC &s1)
{
	cin >> s1.a >> s1.b;
}
SOPHUC tinhtong(SOPHUC s1,SOPHUC s2)
{
	SOPHUC kq;
	kq.a = s1.a + s2.a;
	kq.b = s1.b +s2.b;
	return kq;
}
SOPHUC tinhhieu(SOPHUC s1,SOPHUC s2)
{
	SOPHUC kq;
	kq.a = s1.a - s2.a;
	kq.b = s1.b - s2.b;
	return kq;
}
SOPHUC tinhtich(SOPHUC s1,SOPHUC s2)
{
	SOPHUC kq;
	kq.a = s1.a * s2.a - s1.b * s2.b;
	kq.b = s1.a*s2.b+s1.b*s2.a;
	return kq;
}
void xuat(SOPHUC s1)
{
	cout << s1.a << " " << s1.b << endl	;
}
