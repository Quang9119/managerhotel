#include <iostream>
using namespace std;
void nhap(int &n);
int timmin(int n);
int A[100];
int main()
{
	int n;
	nhap(n);
	int min = timmin(n);
	cout << min;
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
int timmin(int n)
{
	if(n==1)
	{
		return A[0];
	}
	else
	{
		int x= timmin(n-1);
		if(A[n-1]< x)
		{
			return A[n-1];
		}
		else
		{
			return x;
		}
	}
}
