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
void nhap(SOPHUC A[],int &n);
SOPHUC tinhtich(SOPHUC A[],int n);
SOPHUC tinhtong(SOPHUC A[],int n);
SOPHUC tich2sophuc(SOPHUC s1,SOPHUC s2);

int main()
{
	int n;
	SOPHUC A[50];
	nhap(A,n);
	SOPHUC tong = tinhtong(A,n);
	xuat(tong);
	SOPHUC tich = tinhtich(A,n);
	xuat(tich);
	return 0;	
}
void nhap1so(SOPHUC &s1)
{
	cin >> s1.a >> s1.b;
}
void nhap(SOPHUC A[],int &n)
{
	cin >> n;
	for(int i=0;i<n;i++)
	{
		nhap1so(A[i]);
	}
}
SOPHUC tong2sophuc(SOPHUC s1,SOPHUC s2)
{
	SOPHUC kq;
	kq.a = s1.a+s2.a;
	kq.b = s1.b+s2.b;
	return kq;
}
SOPHUC tinhtong(SOPHUC A[],int n)
{
	SOPHUC kq=A[0];
	for(int i=1;i<n;i++)
	{
		kq = tong2sophuc(A[i],kq);
	}
	return kq;
}
SOPHUC tinhtich(SOPHUC A[],int n)
{
	SOPHUC kq=A[0];
	for(int i=1;i<n;i++)
	{
		kq = tich2sophuc(A[i],kq);
	}
	return kq;
}
SOPHUC tich2sophuc(SOPHUC s1,SOPHUC s2)
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
