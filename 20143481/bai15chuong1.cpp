#include <iostream>
#include <string.h>
using namespace std;
struct LINHKIEN
{
	char ten[31];
	char quycach[11];
	char loai;
	int dongia;
};
void nhap(LINHKIEN A[],int &n);
void sapxeptheoloaiten(LINHKIEN A[],int n);
void xuat(LINHKIEN A[],int n);
bool kiemtra(LINHKIEN A[],int n);

int main()
{
	LINHKIEN A[100];
	int n;
	nhap(A,n);
	sapxeptheoloaiten(A,n);
	xuat(A,n);
	bool kt = kiemtra(A,n);
	cout << kt;
	return 0;
}
void nhap1linhkien(LINHKIEN &x)
{
	fflush(stdin);
	cout << "Nhap ten : ";
	cin.getline(x.ten,31);
	cout << "Nhap quy cach : ";
	cin.getline(x.quycach,11);
	cout << "Nhap loai : ";
	cin >> x.loai;
	cout << "Nhap gia : ";
	cin >> x.dongia;
}
void nhap(LINHKIEN A[],int &n)
{
	cin >>n;
	for(int i=0;i<n;i++)
	{
		nhap1linhkien(A[i]);
	}
}
void sapxeptheoloaiten(LINHKIEN A[],int n)
{
	for(int i=0;i<n-1;i++)
	{
		for(int j=i+1;j<n;j++)
		{
			if(A[i].loai > A[j].loai || A[i].loai == A[j].loai && strcmp(A[i].ten,A[j].ten)>0)
			{
				LINHKIEN t = A[i];
				A[i]=A[j];
				A[j]=t;
			}
		}
	}
}
bool kiemtra(LINHKIEN A[],int n)
{
	int d=0;
	for(int i=0;i<n;i++)
	{
		if(A[i].loai=='A'|| A[i].loai=='B')
		{
			d++;
		}
	}
	if(d>=10)
	{
		return true;
	}
	return false;
}
void xuat1linhkien(LINHKIEN x)
{
	cout << "Ten : " << x.ten << endl;
	cout << "Quy cach : " << x.quycach << endl;
	cout << "Loai : " << x.loai << endl;
	cout << "Don gia : " << x.dongia << endl;
}
void xuat(LINHKIEN A[],int n)
{
	for(int i=0;i<n;i++)
	{
		xuat1linhkien(A[i]);
	}
}

