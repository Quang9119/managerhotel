#include <iostream>
#include <string.h>
using namespace std;
int doi(int n,char S[]);
void xuat(char S[]);

int main()
{
	int n;
	char S[100];
	cin >>n;
	doi(n,S);
	return 0;
}
int doi(int n,char S[])
{
	for(int i=1;i<=n;i++)
	{
		S[100]={0};
		int k = i;
		int m=0;
		while(k>0)
		{
			int x = k%2;
			S[m++]=x +48;
			k/=2;
		}
		strrev(S);
		xuat(S);
	}	
}
void xuat(char S[])
{
	cout <<S << endl;
}
