#include <iostream>
#include<string.h>
using namespace std;
void dem(char S[],char A[]);
bool chuaxuathien(int x ,char A[]);

int main()
{
	char S[100],A[100];
	gets(S);
	dem(S,A);
	return 0;
}
bool chuaxuathien(char x ,char A[])
{
	int dem=0;
	for(int i=0;i<strlen(A);i++)
	{
		if(A[i]==x)
		{
			return false;
		}
	}
	return true;
}
void dem(char S[],char A[])
{
	int dem=0;
	int iA=0;
	int n=strlen(S);
	for(int i=0;i<n;i++)
	{
		if(chuaxuathien(S[i],A))
		{
			A[iA++]=S[i];
		}
	}
	for(int i=0;i<iA;i++)
	{
		cout << A[i];
	}
	for(int i=0;i<iA;i++)
	{
		for(int j=0;j<n;j++)
		{
			if(S[j]==A[i])
			{
				dem++;
			}
		}
		cout << endl << dem << endl;
		dem=0;
	}
}
