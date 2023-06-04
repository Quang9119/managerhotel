#include <iostream>
using namespace std;
void thuattoanEratosthene(bool kt[],int n);
void xuatnguyento(bool kt[],int n);

int main()
{
	int n;
	cin >>n;
	bool kt[n+1];
    thuattoanEratosthene(kt,n);
    xuatnguyento(kt,n);
    return 0;
}
void thuattoanEratosthene(bool kt[],int n)
{
	for(int i=2;i<=n;i++)
	{
		kt[i]=true;
	}
	for(int i=2;i<=n;i++)
	{
		if(kt[i]==true)
		{
			for(int j=2*i;j<=n;j+=i)
			{
				kt[j]=false;
			}
		}
	}
}
void xuatnguyento(bool kt[],int n)
{
	for(int i=2;i<=n;i++)
	{
		if(kt[i]==true)
		{
			cout <<i << " ";
		}
	}
}
