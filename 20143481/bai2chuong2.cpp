#include <iostream>
using namespace std;
void nhap(int A[],int &n,int &x);
int tinh(int A[],int n,int x);

int main()
{
	int A[1000],n,x;
	nhap(A,n,x);
	int kiemtra = tinh(A,n,x);
	cout << kiemtra;
	return 0;
}
void nhap(int A[],int &n,int &x)
{
	cin >> n >> x;
	for(int i=0;i<n;i++)
	{
		cin >> A[i];
	}
}
int tinh(int A[],int n,int x)
{
	int left = 0;
	int right =n-1;
	while(right >=left)
	{
		int mid=(left+right)/2;
		if(A[mid]==x)
		{
			return mid;
		}
		if(A[mid]>x)
		{
			right=mid-1;
		}
		if(A[mid]<x)
		{
			left = mid +1;
		}
	}
	return -1;
}
