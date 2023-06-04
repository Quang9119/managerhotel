#include <iostream>
using namespace std;
long tinh(int n);

int main()
{
	int n;
	cin >> n;
	if(n==1)
	{
		cout << 1;
		return 0;	
	}
	if(n==0)
	{
		cout << 0;
		return 0;	
	} 
	long tong = tinh(n);
	cout << tong;
}
long tinh(int n)
{
	int tongtruoc = 0;
	int tongsau =1;
	int tong=0;
	for(int i=2;i<=n;i++)
	{
		tong=tongsau + tongtruoc;
		tongtruoc=tongsau;
		tongsau = tong;
	}
	return tong;
}
