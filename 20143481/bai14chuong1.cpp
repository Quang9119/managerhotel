#include <iostream>
#include <string.h>
using namespace std;

struct MAYTINH
{
	char loaimay[20];
	char noisx[50];
	int thoigianbaohanh;
};
void nhap(MAYTINH A[],int &n);
int tinhdembaohanh(MAYTINH A[],int n);
void danhsachmaymy(MAYTINH A[],int n);

int main()
{
	int n;
	MAYTINH A[50];
	nhap(A,n);
	int dembaohanh = tinhdembaohanh(A,n);
	cout <<dembaohanh;
	cout << endl;
	danhsachmaymy(A,n);
	return 0;
}
void nhap1maytinh(MAYTINH &x)
{
	fflush(stdin);
	cout << "Nhap loai may : ";
	gets(x.loaimay);
	cout << "Nhap noi san xuat : ";
	gets(x.noisx);
	cout << "Nhap thoi gian bao hanh : ";
	cin >> x.thoigianbaohanh;
}
int tinhdembaohanh(MAYTINH A[],int n)
{
	int d=0;
	for(int i=0;i<n;i++)
	{
		if(A[i].thoigianbaohanh==1)
		{
			d++;
		}
	}
	return d;
}
void xuat(MAYTINH x)
{
	cout << "loai may : " << " " << x.loaimay << endl;
	cout << "noi san xuat : " << " " << x.noisx << endl;
	cout << "thoi gian bao hanh : " << " " << x.thoigianbaohanh << endl;
}
void danhsachmaymy(MAYTINH A[],int n)
{
	for(int i=0;i<n;i++)
	{
		if(strcmp(A[i].noisx,"my")==0)
		{
			xuat(A[i]);
		}
	}
}
void nhap(MAYTINH A[],int &n)
{
	cin >>n;
	for(int i=0;i<n;i++)
	{
		nhap1maytinh(A[i]);
	}
}
