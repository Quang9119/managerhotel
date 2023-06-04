#include<iostream>

#include<math.h>

using namespace std;

struct TIME
{

int h, m, s;
};

int TGHopLe(TIME x);
int KhoangCach(TIME t1, TIME t2);
void nhap(TIME &x);

int main()
{
	TIME t1, t2;
	
	nhap (t1);
	
	nhap (t2);
	
	int kt1=TGHopLe(t1);
	
	int kt2=TGHopLe(t2);
	if (kt1==1 && kt2==1)
	{
		cout<<" Hop le"<<endl;
		int kq= KhoangCach(t1,t2);
		cout<<"Khoang cach giua 2 thoi gian la : ";
		cout<<kq<<" giay";
	
	}
	else
		cout<<"Thoi gian da nhap khong hop le";
	return 0;
}
void nhap (TIME &x)
{

	cin>>x.h>>x.m>>x.s;
}
int TGHopLe (TIME x)
{
	if (x.h>-1 && x.h<24 && x.m>-1 && x.m<60 && x.s>-1 && x.s<60)
		return 1;
	return 0;
}
int KhoangCach(TIME t1, TIME t2)
{
	int kc1=t1.s+t1.m*60+t1.h*3600;
	int kc2=t2.s+t2.m*60+t2.h*3600;
	int kc=abs ( kc1 - kc2);
	return kc;
}

