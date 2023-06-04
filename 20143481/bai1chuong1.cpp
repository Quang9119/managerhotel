#include<iostream>
#include<stdio.h>
using namespace std;
struct DATE
{
	int d,m,y;
};
struct HOCSINH
{
	char MSHS[5];
	char hoten[30];
	DATE ngaysinh;
	char diachi[50];
	char phai[3];
	float diemtb;
};
void nhap(HOCSINH A[],int &n);
void xuat(HOCSINH A[],int n);
int tinhsolenlop(HOCSINH A[],int n);

int main()
{
	int n;
	HOCSINH A[50];
	nhap(A,n);
	xuat(A,n);
	cout << "\nSo hoc sinh duoc len lop la : " ;
	int dem = tinhsolenlop(A,n);
	cout << dem << endl;
	return 0;
}
void nhap1hocsinh(HOCSINH &x)
{
	fflush(stdin);
	cout << "Nhap ma so hoc sinh : ";
	gets(x.MSHS);
	cout << "Nhap ho ten hoc sinh : ";
	gets(x.hoten);
	cout << "Nhap ngay thang nam sinh : ";
	cin>> x.ngaysinh.d >> x.ngaysinh.m >> x.ngaysinh.y;
	cout << "Nhap dia chi hoc sinh : ";
	fflush(stdin);
	gets(x.diachi);
	cout << "Nhap phai hoc sinh : ";
	gets(x.phai);
	cout << "Nhap diem trung binh hoc sinh : ";
	cin >> x.diemtb;
}
void nhap(HOCSINH A[],int &n)
{
	cin >> n;
	for(int i=0;i<n;i++)
	{
		nhap1hocsinh(A[i]);
	}
}
int tinhsolenlop(HOCSINH A[],int n)
{
	int d=0;
	for(int i=0;i<n;i++)
	{
		if(A[i].diemtb >=5)
		{
			d++;
		}
	}
	return d;
}
void xuat1hocsinh(HOCSINH &x)
{
	cout << "Ma so hoc sinh : " << x.MSHS << endl;
	cout << "Ho ten hoc sinh : " << x.hoten << endl; 
	cout << "Ngay thang nam sinh hoc sinh : " << x.ngaysinh.d <<"\n" << x.ngaysinh.m << "\n" << x.ngaysinh.y << endl; 
	cout << "Dia chi hoc sinh : " << x.diachi << endl;
	cout << "Phai hoc sinh : " << x.phai << endl;
	cout << "Diem trung binh hoc sinh : " << x.diemtb << endl;
}
void xuat(HOCSINH A[],int n)
{
	for(int i=0;i<n;i++)
	{
		xuat1hocsinh(A[i]);
	}
}
