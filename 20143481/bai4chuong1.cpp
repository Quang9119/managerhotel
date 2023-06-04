#include <iostream>
#include <math.h>
using namespace std;

struct DATE
{
	int d,m,y;
};

void nhap(DATE &ngay1);
int hople(DATE ngay1);
int khoangcach2ngay(DATE ngay1,DATE ngay2);
bool lanamnhuan(int y);

int main()
{
	DATE ngay1,ngay2;
	nhap(ngay1);
	nhap(ngay2);
	int kt1 = hople(ngay1);
	int kt2 = hople(ngay2);
	if(kt1==1 && kt2==1)
	{
		cout << "Hop le " << endl;
		int kq = khoangcach2ngay(ngay1,ngay2);
		cout << kq;
	}
	else 
	{
		cout << "Khong hop le";
	}
}
void nhap(DATE &ngay1)
{
	cin >> ngay1.d >> ngay1.m >> ngay1.y;
}
int hople(DATE ngay1)
{
	if(ngay1.d>0 && ngay1.d <32 && ngay1.m >0 && ngay1.m<13 && ngay1.y>0)
	{
		return true;
	}
}

int tinhsongaycacthangtrc(int i,int y)
{	
	if (i==2)
		if (lanamnhuan(y))
			return 29;
		else
			return 28;
	else
		if (i==4||i==6||i==9||i==11)
			return 30;
		else
			return 31;
}
int tinhsongaytudaunam(int d, int m, int y)
{
	int songay = d;
	for(int i=1;i<m;i++)
		songay=songay+ tinhsongaycacthangtrc(i,y);
	return songay;
}

bool lanamnhuan(int y)
{
	if((y%4==0 && y%100!=0) || y%400==0)
		return true;
	else
		return false;
}

int tinhsongay(int d,int m,int y)
{
	int kc=0;
	for(int i=1;i<=y;i++)
		if(lanamnhuan(i)==true)
		kc=kc+366;
	else
		kc=kc+365;
	kc=kc+tinhsongaytudaunam(d,m,y);
	return kc;
 } 
int khoangcach2ngay(DATE ngay1,DATE ngay2)
{
	int kc1=tinhsongay(ngay1.d,ngay1.m,ngay1.y);
	int kc2=tinhsongay(ngay2.d,ngay2.m,ngay2.y);
	int songay = abs(kc1-kc2);
	return songay;	
}
