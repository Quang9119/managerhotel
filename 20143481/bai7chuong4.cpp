#include <iostream>
#include <string.h>
using namespace std;
int tinh(char S[]);

int main()
{
	char S[10000];
	gets(S);
	int tong = tinh(S);
	cout <<tong;
	return 0;
}
int tinh(char S[])
{
	int tong=0;
	int so=0;
	int n =strlen(S);
	for(int i=0;i<=n;i++)
	{
		if (S[i]>='0' && S[i]<='9')
		{
			so =so*10+(S[i]-'0');
		}
		else
		{
			tong+=so;
			so=0;
		}
	}
	return tong;
}
