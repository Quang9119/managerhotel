#include <iostream>
using namespace std;
int nextday(int d,int m,int y);
void xuat(int day);

int main()
{
	int d,m,y;
	cin >> d >> m >> y;
	int day = nextday(d,m,y);
	xuat(day);
	return 0;
}
bool lanamnhuan(int x)
{
	if((x%4==0 && x%100!=0 )|| x%400==0)
	{
		return true;
	}
	return false;
}
int nextday(int d,int m,int y)
{
	if(d>31||d<=0||m>12||m<=0||y<=0)
	{
		return 0;
	}
	switch(m)
	{
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12:
			if(d==31) 
			{
				return 1;
			}
			return d+1;
		case 2:
			if(lanamnhuan(y))
			{
				if(d==29)
				{
					return 1;
				}
				return d+1;
			}
			else 
			{
				if(d==28)
				{
					return 1;
				}
				return d+1;
			}
		default :
			if(d==30)
			{
				return 1;
			}
			return d+1;
	}
}
void xuat(int day) 
{
	if(day==0) 
	{
		cout << " Ngay,thang, nam khong hop le." << endl;
	}
	else 
	{
		cout << day;
	}
}
