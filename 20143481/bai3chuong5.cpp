#include <iostream>
using namespace std;
int tinh(int A[],int n);

int main()
{
	int A[100],n;
	cin >>n;
	for(int i=0;i<n;i++)
	{
		cin >>A[i];
	}
	int lemin = tinh(A,n);
	cout <<lemin;
	return 0;
}
int tinh(int A[],int n)
{
	int maxchan = -99999998;
	int minle = 99999999;
	for(int i=0;i<n;i++)
	{
		if(A[i]%2==0 && A[i]>maxchan)
		{
			maxchan = A[i];
		}
	}
	for(int i=0;i<n;i++)
	{
		if(A[i]%2==1 && A[i]>maxchan && A[i]<minle)
		{
			minle=A[i];
		}
	}
	return minle;
}
