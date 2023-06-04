#include <iostream>
using namespace std;
int maxcontang(int A[],int n,int L[]);

int main()
{
	int n,A[10000],L[10000];
	cin>>n;
	for(int i=0;i<n;i++)
	{
		cin >> A[i];
	}
	int max =maxcontang(A,n,L);
	cout << max;
	return 0;
}
int maxcontang(int A[],int n,int L[])
{
	for(int i=0;i<n;i++)
	{
		L[i]=1;
		for(int j=0;j<i;j++)
		{
			if(A[j]<=A[i] && L[i]<L[j]+1)
			{
				L[i]=L[j]+1;
			}
		}
	}
	int max = L[0];
	{
		for(int i=1;i<n;i++)
		{
			if(L[i]>max)
			{
				max= L[i];
			}
		}
	}
	return max;
}
