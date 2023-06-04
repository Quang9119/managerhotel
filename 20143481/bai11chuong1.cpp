#include <iostream>
#include <string.h>
using namespace std;

struct SINHVIEN
{
	int masv;
	char ten[20];
	int namsinh;
	float diemtoan;
	float diemly;
	float diemhoa;
	float diemtb;
};
void nhap(SINHVIEN A[],int &n);
void xuat(SINHVIEN A[],int n);
void xuat1sinhvien(SINHVIEN x);
SINHVIEN timsinhvientbmax(SINHVIEN A[],int n);
void sapxeptheodiemtb(SINHVIEN A[],int n);
void sapxepgiamtheodiemtoan(SINHVIEN A[],int n);
void timkiemdudk(SINHVIEN A[],int n);
SINHVIEN tinhmaxtuoi(SINHVIEN A[],int n);
void timsv(SINHVIEN A[],int n,char ten[]);

int main()
{
	int n;
	SINHVIEN A[50];
	nhap(A,n);
	xuat(A,n);
	SINHVIEN maxtb = timsinhvientbmax(A,n);
	xuat1sinhvien(maxtb);
	sapxeptheodiemtb(A,n);
	cout << "d) " << endl;
	xuat(A,n);
	sapxepgiamtheodiemtoan(A,n);
	cout << "e) " << endl;
	xuat(A,n);
	timkiemdudk(A,n);
	SINHVIEN tuoimax = tinhmaxtuoi(A,n);
	xuat1sinhvien(tuoimax);
	char ten[50];
	fflush(stdin);
	cout << "Nhap ten sinh vien can tim: ";
	cin.getline(ten,31);
	timsv(A,n,ten);
	return 0;
}
void nhap1sinhvien(SINHVIEN &x)
{
	
	cout << "Nhap masv : ";
	cin >> x.masv;
	fflush(stdin);
	cout << "Nhap ten sv : ";
	gets(x.ten);
	cout << "Nhap nam sinh : ";
	cin >> x.namsinh;
	cout << "Nhap diem toan : ";
	cin >> x.diemtoan;
	cout << "Nhap diem ly : ";
	cin >> x.diemly;
	cout << "Nhap diem hoa : ";
	cin >> x.diemhoa;
	x.diemtb = (x.diemtoan+x.diemly+x.diemhoa)/3;
}
void nhap(SINHVIEN A[],int &n)
{
	cin >>n;
	for(int i=0;i<n;i++)
	{
		nhap1sinhvien(A[i]);
	}
}
int sosanh(SINHVIEN x,SINHVIEN y)
{
	if(x.diemtb>y.diemtb)
	{
		return true;
	}
	return false;
}
void timsv(SINHVIEN A[],int n,char ten[])
{
	bool kt =false;
	for(int i=0;i<n;i++)
	{
		if(strcmp(A[i].ten,ten)==0)
		{
			kt = true;
			xuat1sinhvien(A[i]);
		}
	}
	if(kt ==false)
	{
		cout << "Khong tim thay.";
	}
}
SINHVIEN timsinhvientbmax(SINHVIEN A[],int n)
{
	SINHVIEN max = A[0];
	for(int i=1;i<n;i++)
	{
		if(sosanh(A[i],max)>0)
		{
			max = A[i];
		}
	}
	return max;
}
void timkiemdudk(SINHVIEN A[],int n)
{
	for(int i=0;i<n;i++)
	{
		if(A[i].diemtb >5 && A[i].diemtoan>3 && A[i].diemly>3 && A[i].diemhoa>3)
		{
			xuat1sinhvien(A[i]);
		}
	}
}
SINHVIEN tinhmaxtuoi(SINHVIEN A[],int n)
{
	SINHVIEN maxtuoi = A[0];
	for(int i=1;i<n;i++)
	{
		if(A[i].namsinh < maxtuoi.namsinh)
		{
			maxtuoi=A[i];
		}
	}
	return maxtuoi;
}
void sapxeptheodiemtb(SINHVIEN A[],int n)
{
	for(int i=0;i<n-1;i++)
	{
		for(int j=i+1;j<n;j++)
		{
			if(A[i].diemtb > A[j].diemtb)
			{
				SINHVIEN t = A[i];
				A[i]=A[j];
				A[j]=t;
			}
		}
	}
}
void sapxepgiamtheodiemtoan(SINHVIEN A[],int n)
{
	for(int i=0;i<n-1;i++)
	{
		for(int j=i+1;j<n;j++)
		{
			if(A[i].diemtoan < A[j].diemtoan)
			{
				SINHVIEN t = A[i];
				A[i]=A[j];
				A[j]=t;
			}
		}
	}
}
void xuat1sinhvien(SINHVIEN x)
{
	
	cout << "masv : ";
	cout << x.masv << endl;
	cout << "ten sv : ";
	cout << x.ten << endl;
	cout << "nam sinh : ";
	cout << x.namsinh<<endl;
	cout << "diem toan : ";
	cout << x.diemtoan<<endl;
	cout << "diemly : ";
	cout << x.diemly<<endl;
	cout << "diem hoa : ";
	cout << x.diemhoa << endl;
	cout << "diem tb : " << x.diemtb << endl;
}
void xuat(SINHVIEN A[],int n)
{
	for(int i=0;i<n;i++)
	{
		xuat1sinhvien(A[i]);
	}
}
