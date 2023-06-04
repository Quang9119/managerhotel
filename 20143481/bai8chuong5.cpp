#include<iostream>
#include <string.h>
using namespace std;
bool tinh(char S[]);

int main()
{
    char S[20];
    gets(S);
    bool ktdx = tinh(S);
    cout << ktdx;
    return 0;
}
bool tinh(char S[])
{
	int n=strlen(S);
	for(int i=0;i<n/2;i++)
	{
		if(S[i]!=S[n-i-1])
		{
			return false;
		}
	}
	return true;
}
