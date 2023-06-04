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
	int max = -999999999;
	int vtd = 0;
	int vtc = n-1;
	for(int i=0;i<n-1;)
	{
		int tong=0;
		int t =A[i];
		tong+=t;
		int j;
		for(j=i+1;j<n;j++)
		{
			if(A[j]>=t)
			{
				t = A[j];
				tong+=t;
			}
			else
			{
				break;
			}
		}
		if(tong>max)
		{
			max=tong;
			vtd = i;
			vtc = j-1;
		}
		i=j;
		
	}
	for(int i=vtd;i<=vtc;i++)
	{
		cout << A[i] << " ";
	}
}
