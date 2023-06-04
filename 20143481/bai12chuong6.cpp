#include <iostream>
#include <string.h>
using namespace std;
int xaumax(char A[], char B[],int L[][100]);

int main()
{
	char A[100],B[100];
	int L[100][100];
	gets(A);
	gets(B);
	int max = xaumax(A,B,L);
	cout << max;
	return 0;
}
int tinhmax(int a,int b)
{
	if(a>b) return a;
	else return b;
}
int xaumax(char A[], char B[],int L[][100])
{
	int m = strlen(A);
	int n = strlen(B);
	for(int i=0;i<=m;i++) L[i][0]=0;
	for(int i=0;i<=n;i++) L[0][i]=0;
	for(int i=1;i<=m;i++)
	{
		for(int j=1;j<=n;j++)
		{
			if(A[i-1]==B[j-1])
			{
				L[i][j]=L[i-1][j-1]+1;
			}
			else
			{
				L[i][j]=tinhmax(L[i-1][j],L[i][j-1]);
			}
		}
	}
	int max = 0;
	for(int i=0;i<=m;i++)
		for(int j=0;j<=n;j++)
		{
			if(L[i][j]>max)
			{
				max=L[i][j];
			}
		}
	return max;	
}
