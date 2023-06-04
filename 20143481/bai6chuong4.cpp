#include <iostream>
using namespace std;
int tinh(int n);

int main()
{
	int n;
	cin >>n;
	int giatri = tinh(n);
	cout <<giatri;
	return 0;
}
int tinh(int n)
{
	if(n==1||n==2)
	{
		return 1;
	}
	else
	{
		return tinh(n-1)+tinh(n-2);
	}
}
