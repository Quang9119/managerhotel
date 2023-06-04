#include <iostream>
#include <string.h>
using namespace std;
void chuanhoa(char S[]);

int main()
{
	char S[20];
	gets(S);
	chuanhoa(S);
	cout << S;
	return 0;
}
xoa1kytu(char S[],int vitri)
{
	int n = strlen(S);
	for(int i=vitri;i<n;i++)
	{
		S[i]=S[i+1];
	}
	S[n]='\0';
}
void chuanhoa(char S[])
{
	for(int i=0;i<strlen(S);i++)
	{
		if(S[i]==' ' && S[i+1]==' ')
		{
			xoa1kytu(S,i);
			i--;
		}
	}
	S[0]-=32;
	for(int i=0;i<strlen(S)-1;i++)
	{
		if(S[i]==' ' && S[i+1]!=' ')
		{
			S[i+1]-=32;
		}
	}
}
