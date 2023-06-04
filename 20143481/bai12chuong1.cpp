#include <iostream>
#include <string.h>
using namespace std;


struct VIDEO
{
	char tenphim[50];
	char theloai[10];
	char tendaodien[20];
	char tendienviennamchinh[20];
	char tendienviennuchinh[20];
	int namsx;
	char hangsx[50];
};
void nhap(VIDEO A[],int &n);
void timkiem(char thongtin[]);
void lietkephim(VIDEO A[],int n,char thongtin[]);
void xuat(VIDEO x);

int main()
{
	int n;
	VIDEO A[50];
	nhap(A,n);
	char thongtin[50];
	timkiem(thongtin);
	lietkephim(A,n,thongtin);
	timkiem(thongtin);
	lietkephim(A,n,thongtin);
	timkiem(thongtin);
	lietkephim(A,n,thongtin);
	return 0;
}
void nhap1video(VIDEO &x)
{
	fflush(stdin);
	cout << "Nhap ten phim : ";
	gets(x.tenphim);
	cout << "Nhap the loai : ";
	gets(x.theloai);
	cout << "Nhap ten dao dien : ";
	gets(x.tendaodien);
	cout << "Nhap ten dien vien nam chinh : ";
	gets(x.tendienviennamchinh);
	cout << "Nhap ten dien vien nu chinh : ";
	gets(x.tendienviennuchinh);
	cout << "Nhap nam san xuat : ";
	cin >> x.namsx;
	fflush(stdin);
	cout << "Nhap ten hang san xuat : ";
	gets(x.hangsx);
}
void lietkephim(VIDEO A[],int n,char thongtin[])
{
	bool kt =false;
	for(int i=0;i<n;i++)
	{
		if(strcmp(A[i].theloai,thongtin)==0 || strcmp(A[i].tendienviennamchinh,thongtin)==0 || strcmp(A[i].tendaodien,thongtin)==0)
		{
			kt = true;
			xuat(A[i]);
		}
	}
	if(kt==false)
	{
		cout << "Khong tim thay" << endl;
	}
}
void timkiem(char thongtin[])
{
	fflush(stdin);
	cout << "Nhap thong tin tim kiem: ";
	cin.getline(thongtin,50);
}
void xuat(VIDEO x)
{
	cout << " ten phim : " << " " << x.tenphim << endl;
	cout << " the loai : "<< " " << x.theloai << endl;
	cout << " ten dao dien : "<< " " << x.tendaodien << endl;
	cout << " ten dien vien nam chinh : "<< " " << x.tendienviennamchinh << endl;
	cout << " ten dien vien nu chinh : "<< " " << x.tendienviennuchinh << endl;
	cout << " nam san xuat : "<< " " << x.namsx << endl;
	cout << " ten hang san xuat : "<< " " << x.hangsx << endl;
}
void nhap(VIDEO A[],int &n)
{
	cin >>n;
	for(int i=0;i<n;i++)
	{
		nhap1video(A[i]);
	}
}
