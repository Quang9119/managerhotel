#include <iostream>
using namespace std;
void cacdaycon(int A[],int n);

int main()
{
	int n,A[100];
	cin >>n;
	for(int i=0;i<n;i++)
	{
		cin >> A[i];
	}
	cacdaycon(A,n);
	return 0;
}
void cacdaycon(int A[],int n)
{
	for(int i=0;i<n-1;)
	{
		int t =A[i];
		cout << endl << t << " ";
		int j;
		for(j=i+1;j<n;j++)
		{
			if(A[j]>=t)
			{
				t = A[j];
				cout << t << " ";
			}
			else
			{
				break;
			}
		}
		i=j;
	}
}
