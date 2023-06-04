#include <iostream>
#include <string.h>
using namespace std;

struct DAUSACH
{
	char masosach[20];
	char tensach[50];
	char tentacgia[50];
	int soluong;
};
void nhap(DAUSACH A[],int &n);
void lietke(DAUSACH A[],int n,char ten[]);
int tinhtong(DAUSACH A[],int n);
void xuat(DAUSACH x);

int main()
{
	int n;
	DAUSACH A[100];
	nhap(A,n);
	char ten[50];
	fflush(stdin);
	cout << "Nhap ten sach can tim: ";
	cin.getline(ten,31);
	lietke(A,n,ten);
	int tong = tinhtong(A,n);
	cout << tong;
	return 0;
}
void nhap1dausach(DAUSACH &x)
{
	fflush(stdin);
	cout << "Nhap ma so sach : ";
	gets(x.masosach);
	cout << "Nhap ten sach : ";
	gets(x.tensach);
	cout << "Nhap ten tac gia : ";
	gets(x.tentacgia);
	cout << "Nhap so luong : ";
	cin >> x.soluong;
}
void lietke(DAUSACH A[],int n,char ten[])
{
	bool kt =false;
	for(int i=0;i<n;i++)
	{
		if(strcmp(A[i].tensach,ten)==0)
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
int tinhtong(DAUSACH A[],int n)
{
	int tong=0;
	for(int i=0;i<n;i++)
	{
		tong+=A[i].soluong;
	}
	return tong;
}
void xuat(DAUSACH x)
{
	cout << "ma so sach : " << " " <<x.masosach << endl;;
	cout << "ten sach : " << " " << x.tensach << endl;;
	cout << "ten tac gia : " << " " << x.tentacgia << endl;
	cout << "so luong : " << " " << x.soluong << endl;
}
void nhap(DAUSACH A[],int &n)
{
	cin >>n;
	for(int i=0;i<n;i++)
	{
		nhap1dausach(A[i]);
	}
}
