#include <iostream>
using namespace std;

struct MATHANG
{
	char mahang[20];
	char tenhang[50];
	int soluong;
	int dongia;
	int soluongton;
	int thoigianbaohanh;
};
void nhap(MATHANG A[],int &n);
MATHANG tonmax(MATHANG A[],int n);
void xuat(MATHANG x);
MATHANG tonmin(MATHANG A[],int n);
MATHANG tinhmaxtien(MATHANG A[],int n);
void inbaohanhhon12thang(MATHANG A[],int n);
void sapxeptangdansoluongton(MATHANG A[],int n);
void xuatmang(MATHANG A[],int n);
int main()
{
	int n;
	MATHANG A[50];
	nhap(A,n);
	MATHANG max = tonmax(A,n);
	xuat(max);
	MATHANG min = tonmin(A,n);
	xuat(min);
	MATHANG maxtien = tinhmaxtien(A,n);
	xuat(maxtien);
	inbaohanhhon12thang(A,n);
	sapxeptangdansoluongton(A,n);
	xuatmang(A,n);
	return 0;
}
void xuat(MATHANG x)
{
	cout << "ma hang : " << " " <<x.mahang << endl;;
	cout << "ten hang : " << " " << x.tenhang << endl;;
	cout << "So luong hang : " << " " << x.soluong << endl;
	cout << "Don gia : " << " " << x.dongia << endl;
	cout << "So luong ton hang : " << " " << x.soluongton << endl;
	cout << "Thoi gian bao hanh : " << " " << x.thoigianbaohanh << endl;
}
MATHANG tonmax(MATHANG A[],int n)
{
	MATHANG tonmax = A[0];
	for(int i=0;i<n;i++)
	{
		if(A[i].soluongton > tonmax.soluongton)
		{
			tonmax = A[i];
		}
	}
	return tonmax;
}
MATHANG tinhmaxtien(MATHANG A[],int n)
{
	MATHANG tonmax = A[0];
	for(int i=0;i<n;i++)
	{
		if(A[i].dongia > tonmax.dongia)
		{
			tonmax = A[i];
		}
	}
	return tonmax;
}
void sapxeptangdansoluongton(MATHANG A[],int n)
{
	for(int i=0;i<n-1;i++)
	{
		for(int j=i+1;j<n;j++)
		{
			if(A[i].soluongton>A[j].soluongton)
			{
				MATHANG t =A[i];
				A[i]=A[j];
				A[j]=t;
			}
		}
	}
}
void inbaohanhhon12thang(MATHANG A[],int n)
{
	for(int i=0;i<n;i++)
	{
		if(A[i].thoigianbaohanh > 12)
		{
			xuat(A[i]);
		}
	}
}
MATHANG tonmin(MATHANG A[],int n)
{
	MATHANG tonmin = A[0];
	for(int i=0;i<n;i++)
	{
		if(A[i].soluongton < tonmin.soluongton)
		{
			tonmin = A[i];
		}
	}
	return tonmin;
}
void nhap1mathang(MATHANG &x)
{
	fflush(stdin);
	cout << "Nhap ma hang : ";
	gets(x.mahang);
	cout << "Nhap ten hang : ";
	gets(x.tenhang);
	cout << "So luong hang : ";
	cin >> x.soluong;
	cout << "Don gia : ";
	cin >> x.dongia;
	cout << "So luong ton hang : ";
	cin >> x.soluongton;
	cout << "Thoi gian bao hanh : ";
	cin >> x.thoigianbaohanh;
}
void xuatmang(MATHANG A[],int n)
{
	for(int i=0;i<n;i++)
	{
		xuat(A[i]);
	}
}
void nhap(MATHANG A[],int &n)
{
	cin >>n;
	for(int i=0;i<n;i++)
	{
		nhap1mathang(A[i]);
	}
}
