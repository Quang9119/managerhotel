#include <iostream>
#include <string.h>
using namespace std;
void dem(char S[]);

int main()
{
	char S[50];
	gets(S);
	dem(S);
	return 0;
}
void dem(char S[])
{
	int n = strlen(S);
	int thuong=0;
	int hoa=0;
	int so=0;
	int khac =0;
	for(int i=0;i<n;i++)
	{
		if(S[i]>='a' && S[i]<='z')
		{
			thuong++;
		}
		else if(S[i]>='A' && S[i]<='Z')
		{
			hoa++;
		}
		else if(S[i]>='0' && S[i]<='9')
		{
			so++;
		}
		else
		{
			khac++;
		}
	}
	cout << thuong << endl << hoa << endl << so << endl <<khac << endl;
}
