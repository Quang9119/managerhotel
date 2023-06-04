#include <iostream>
using namespace std;
void nhap(int &n);
int tinhtong(int n);
int A[100];
int main()
{
	int n;
	nhap(n);
	int tong = tinhtong(n);
	cout << tong;
	return 0;
}
void nhap(int &n)
{
	cin >> n;
	for(int i=0;i<n;i++)
	{
		cin >> A[i];
	}
}
int tinhtong(int n)
{
	int tong=A[n-1];
	if(n==1)
	{
		return A[0];
	}
	else
	{
		return tong + tinhtong(n-1);
	}
}
