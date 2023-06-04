#include <iostream>
#include <string.h>
using namespace std;
void dao(char S[]);
//asdfghj buusa sdfr asd ht a
int main()
{
	char S[100000];
	gets(S);
	dao(S);
	return 0;
}
void dao(char S[])
{
	char A[100000]="";
	int iA=0;
	int n=strlen(S);
	for(int i=0;i<n;i++)
	{
		if(S[i]!=' ')
		{
			A[iA++]=S[i];
		}
		else
		{
			strrev(A);
			cout << A << " ";
			memset(A, '\0', sizeof(A));
			iA=0;
		}
	}
	if(S[n-1]!=' ')
	{
		strrev(A);
		cout << A << " ";
	}
}
