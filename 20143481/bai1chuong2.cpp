#include <iostream>
using namespace std;
void nhap(int A[],int &n,int &x) ;
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
	A[n]=x;
	int i=0;
	while(A[i]!=x)
	{
		i++;
	}
	if(i<n)
	{
		return i;
	}
	else
	{
		return -1;
	}
}
